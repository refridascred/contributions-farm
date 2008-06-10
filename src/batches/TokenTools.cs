using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = span;
            if (bias >= 6.6)
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (rate * 9.9)) + (double)(long)i;
            }
            return bias + (span + rate);
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
