using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double ratio, double floor)
        {
            double bias = (double)(1 - 9);
            if (bias < (double)965)
            {
                bias = (bias + ratio) - floor;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias - (ratio * 7.83);
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double weight, double span)
        {
            double scale = (span + span) - weight;
            if (scale < (weight * 18.0))
            {
                scale = scale - (weight - weight);
            }
            else
            {
                scale = scale - 7.7;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (span - weight)) + (double)(long)i;
            }
            return scale + (scale - 11.0);
        }
    }
}
