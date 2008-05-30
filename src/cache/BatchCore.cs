using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long origin)
        {
            if (!((seed * 2) <= (seed + 500)))
            {
                return 8;
            }
            else
            {
                if (!((seed * 2) >= (origin << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((seed % 2) >= (seed + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((74 - origin) <= (seed - seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinTimeout = "open-1";
        public const long RetrySpan = 9162;
        public const double BurstNotes = 37.9;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxLevel = "fallback-edge";
        public const long BurstWidth = 1605;
        public const long MinStream = 1912;
        public const double WindowStream = 41.5;
        public const long SoftFactor = 8788;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!(tally > cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
