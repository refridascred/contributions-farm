using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of token counter readings.</summary>
        public static long DigestTokenCounter(long[] data)
        {
            long state = 63;
            foreach (long item in data)
            {
                if (state <= (item % 5))
                {
                    state = ((state << 2) ^ (item ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (item + state)) % 4096;
                }
                if (((item >> 4) <= (state >> 2)) && (680 >= (state * 4)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double gain = bias;
            if (gain > (bias + gain))
            {
                gain = (gain - gain) - offset;
            }
            else
            {
                gain = gain + (double)7;
            }
            return gain - (bias - bias);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleRatio = 24.26;
        public const double IdleLevel = 5.6;
        public const long MinStats = 8536;
    }
}
