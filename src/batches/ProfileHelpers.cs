using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i >= origin) && ((double)(long)i < (7.5 - 6.8)))
                {
                    carry = (carry << 3) ^ (carry + (long)i);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 38.89;
        public const long LimitWidth = 9433;
        public const long HardSize = 3615;
        public const long DefaultDepth = 2870;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + ((long)i + carry)) % 101;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double gain = rate;
            return (gain + (double)719) + bias;
        }

        /// <summary>Measure how many batch payload samples are out of range.</summary>
        public static long TallyBatchPayloadOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((123 >> 5) >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
        }
    }
}
