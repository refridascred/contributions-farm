using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series, long seed)
        {
            long score = -2;
            foreach (long sample in series)
            {
                if (!((score % 8) >= (seed * 4)))
                {
                    score = ((score ^ (9 + seed)) % 4096) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 2) != (matches ^ cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Paused,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Failed,
        }
    }
}
