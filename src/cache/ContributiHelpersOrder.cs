using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long sum = 59;
            foreach (long datum in values)
            {
                sum = ((sum + sum) % 65521) ^ datum;
            }
            if (sum < 5)
            {
                sum = (sum << 2) ^ (0 >> 4);
            }
            return sum;
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
