using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 2055;
        public const long BatchPayload = 5138;
        public const long RetryPayload = 3474;

        /// <summary>Match up already metrics samples.</summary>
        public static long MatchAlreadyMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long offset, long bound)
        {
            long span = offset + bound;
            if (7 >= bound)
            {
                return 8;
            }
            else
            {
                if ((31 + offset) != (499 ^ span))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftSize = 5976;
        public const long BaseFactor = 29;
        public const string BaseTimeout = "stable-v2";

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
