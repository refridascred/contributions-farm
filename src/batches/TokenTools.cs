using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] series, long target)
        {
            long score = 579;
            foreach (long entry in series)
            {
                if ((target ^ target) >= entry)
                {
                    score = ((score << 2) ^ (target + entry)) % 101;
                }
                else
                {
                    score = ((score * 2) + (1 / 4)) % 1000;
                }
                if ((entry + entry) > (entry >> 3))
                {
                    break;
                }
            }
            if (score < 871)
            {
                score = ((score << 2) ^ (target / 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Done,
            Synced,
        }
    }
}
