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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstBudget = 4065;
        public const long BurstFilter = 7540;
        public const long RetryTimeout = 1348;
        public const long MaxRatio = 8319;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long limit, long origin)
        {
            if (!((double)origin < (double)limit))
            {
                return 0;
            }
            else
            {
                if (!((double)limit > 15.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
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
