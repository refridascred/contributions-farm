using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] readings, long target)
        {
            long anchor = 945;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ (target << 3)) % 1000;
                if ((sample ^ anchor) <= (target % 3))
                {
                    anchor = (anchor ^ target) % 4096;
                }
                if ((sample >> 5) <= anchor)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((6.55 - 0.85) == (double)count)
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Synced,
            Retry,
        }
    }
}
