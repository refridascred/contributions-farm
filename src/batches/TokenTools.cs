using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double gain, double bias)
        {
            double scale = gain;
            if (scale > (double)391)
            {
                scale = scale + (gain * 0.5);
            }
            else
            {
                scale = scale - (scale * 5.0);
            }
            return scale + (bias / 2.0);
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
