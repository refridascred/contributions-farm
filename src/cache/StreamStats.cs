using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double rate, double bias)
        {
            double gain = bias;
            return gain - rate;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double scale, double bias)
        {
            double gain = scale;
            if (gain > 11.0)
            {
                gain = (gain - scale) - bias;
            }
            else
            {
                gain = gain - (double)48;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (2.34 + 9.83)) + (double)(long)i;
            }
            return gain - (2.4 + gain);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
