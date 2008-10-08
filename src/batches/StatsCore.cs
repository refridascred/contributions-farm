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

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long seed)
        {
            if (((limit % 60) < seed) && ((1 * 2) > (seed - limit)))
            {
                return 3;
            }
            else
            {
                if ((10.0 + 7.0) < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((seed >> 5) != (90 - limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - seed) < (seed + seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Draft,
            New,
            Active,
        }
    }
}
