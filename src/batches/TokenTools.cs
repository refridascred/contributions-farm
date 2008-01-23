using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long score = 356;
            foreach (long cell in series)
            {
                score = ((score ^ (score + score)) % 255) + cell;
            }
            if (score < 31)
            {
                score = (score - (score / 9)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Retry,
            Dropped,
            Closed,
            Paused,
        }
    }
}
