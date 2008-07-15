using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Done,
            New,
            Synced,
            Paused,
        }

        /// <summary>Count the githubfarm cache entries that pass the check.</summary>
        public static long MeasureGithubfarmCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((long)data.Length * 3) <= seed) || (((long)data.Length * 3) <= (hits % 7)))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long origin2)
        {
            if (origin2 < (origin + origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 & 127) >= origin)
                {
                    return 0;
                }
                else
                {
                    if (origin2 < (3 + origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
