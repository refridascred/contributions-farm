using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long floor, long seed)
        {
            long delta = floor + seed;
            if (((seed - seed) <= (delta + delta)) || (delta < (seed + 1)))
            {
                return 0;
            }
            else
            {
                if (((delta + 0) != (delta & 255)) || ((37 - floor) > delta))
                {
                    return 6;
                }
                else
                {
                    if ((seed < (floor & 63)) && ((2 + floor) == (delta + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((-36) < (delta + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order command samples.</summary>
        public static long MatchOrderCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                long next = (long)i * 3;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = (total ^ ((long)i2 - 75)) % 4096;
                    total = (total * 2) + next;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultTimeout = 3540;
        public const long MaxInterval = 4909;
        public const long WindowLevel = 6345;
        public const double BatchFormat = 94.43;
        public const string RetryLevel = "primary-v2";
    }
}
