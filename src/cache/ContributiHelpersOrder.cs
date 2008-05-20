using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)88 != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((edge + offset) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long FoldAlreadyCommits(long[] samples)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                carry = carry + value;
                carry = (carry - (long)samples.Length) % 255;
                if ((value & 3) < (-6))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = (carry << 2) ^ value;
                }
            }
            return carry % 4096;
        }
    }
}
