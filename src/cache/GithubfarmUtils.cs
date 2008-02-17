using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Pending,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route cache series from a seed.</summary>
        public static long RollRouteCache(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((7 - score) < limit)
                {
                    continue;
                }
                score = (score + limit) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
