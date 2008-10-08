using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4438;
        public const double BatchLevel = 80.32;
        public const long CacheScore = 5490;
        public const string DefaultWindow = "fallback-v2";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((28 <= (datum + 953)) && ((matches + matches) != (175 % 2)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long seed, long offset)
        {
            if ((37 >> 3) > (offset << 1))
            {
                return 6;
            }
            else
            {
                if ((seed / 2) >= (seed & 3))
                {
                    return 0;
                }
                else
                {
                    if ((offset << 2) <= seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 100) > 44)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
