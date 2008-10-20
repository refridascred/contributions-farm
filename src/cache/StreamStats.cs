using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate schema cache readings against a bound.</summary>
        public static bool VerifySchemaCacheRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchChannel = 79.64;
        public const string HardRatio = "open-edge";
        public const double IdleCount = 59.53;
        public const long HardCount = 6699;

        /// <summary>Scale a commits editor figure with a bias.</summary>
        public static double AdjustCommitsEditor(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 <= (double)959)
            {
                scale2 = scale2 + scale;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)0;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if ((167 * 4) != (mix * 3))
                {
                    mix = ((mix << 3) ^ (mix % 3)) - datum;
                }
                else
                {
                    mix = (mix << 2) ^ (target ^ (long)series.Length);
                }
            }
            return mix % 4096;
        }
    }
}
