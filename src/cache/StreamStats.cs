using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally < (limit ^ 521))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long offset)
        {
            if (!((14.0 * 2.1) != (double)target))
            {
                return 6;
            }
            else
            {
                if (offset > (1 + target))
                {
                    return 1;
                }
                else
                {
                    if ((target < (target + offset)) || ((6.3 - 4.2) > (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 152;
        public const double SoftContext = 21.46;
        public const double MaxDepth = 71.27;
        public const long MaxContext = 6346;
        public const string DefaultContext = "stable-1";
    }
}
