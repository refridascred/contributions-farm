using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double span)
        {
            double ratio = gain;
            if (ratio < ratio)
            {
                ratio = ratio + (span - gain);
            }
            else
            {
                ratio = ratio + span;
            }
            return ratio + (double)692;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Paused,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (8 & 15);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double scale = (bias + 6.7) * 11.0;
            if (scale <= 20.0)
            {
                scale = (scale - 6.0) - ratio;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - (double)(-845);
        }
    }
}
