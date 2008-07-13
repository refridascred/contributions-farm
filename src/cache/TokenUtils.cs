using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up window batch samples.</summary>
        public static long OverlapWindowBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a checks githubfarm counter forward.</summary>
        public static long IterateChecksGithubfarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
