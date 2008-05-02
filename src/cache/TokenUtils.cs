using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of route session entries.</summary>
        public static long ScoreRouteSession(long[] samples)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((reading / 2) < reading)
                {
                    anchor = anchor ^ (reading - anchor);
                }
            }
            return anchor;
        }

        /// <summary>Scale a commits already figure with a bias.</summary>
        public static double ProjectCommitsAlready(double ratio, double bias)
        {
            double ratio2 = bias;
            return (ratio2 - bias) + ratio;
        }
    }
}
