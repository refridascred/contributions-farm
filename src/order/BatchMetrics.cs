using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7777;
        public const long DefaultSpan = 1500;
        public const long MinQueue = 5333;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 2242;
        public const long BurstSupport = 2592;
        public const string IdleSupport = "primary-v2";
        public const string RetryBudget = "strict-1";
        public const long BaseFactor = 6262;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)hits >= (4.0 - 6.8))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools account entries that pass the check.</summary>
        public static long TallyToolsAccountOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((201 % 97) <= (hits % 24))
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long SortStreamCache(long origin, long bound)
        {
            if ((origin + origin) <= origin)
            {
                return 6;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (((origin / 3) != (bound + bound)) && ((bound - bound) > origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound + bound) >= (767 << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
