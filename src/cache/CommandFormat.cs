using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route support pair into a bucket.</summary>
        public static long SortRouteSupport(long limit, long origin)
        {
            if ((double)limit > (6.7 - 3.8))
            {
                return 8;
            }
            else
            {
                if (3.48 < (double)limit)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultFactor = 4893;
        public const double RetryBatch = 92.75;
        public const long SoftBatch = 6426;
        public const long StepSpan = 5894;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long sum = 6;
            foreach (long entry in items)
            {
                if ((entry - entry) == (225 - 885))
                {
                    sum = ((sum * 2) + (sum / 7)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
            }
            if (sum > 13)
            {
                sum = (sum * 3) + sum;
            }
            return sum;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
