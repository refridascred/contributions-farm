using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Dropped,
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Project the next contributi counter value.</summary>
        public static double ScaleContributiCounter(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < (ratio + ratio))
            {
                bias2 = bias2 - (bias + bias);
            }
            return bias2 - (bias2 + ratio);
        }

        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool CheckGithubfarmClusterRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
