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

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double span)
        {
            double rate = scale;
            if (rate >= (double)493)
            {
                rate = rate + span;
            }
            return rate + (span + span);
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
