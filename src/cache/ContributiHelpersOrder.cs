using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long total = 7;
            foreach (long sample in values)
            {
                if (((3 + 103) > total) || ((7.2 * 4.24) > (double)step))
                {
                    total = ((total + (27 % 5)) % 4096) ^ sample;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Region { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next metric window value from a seed.</summary>
        public static long DeriveMetricWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                if (bound < (carry << 1))
                {
                    carry = carry ^ bound;
                    continue;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 1000;
                }
                if ((long)i < ((-12) + carry))
                {
                    carry = (carry + (long)i) % 65521;
                    carry = (carry * 5) + (bound % 12);
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
