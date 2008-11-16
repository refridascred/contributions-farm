using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Pending,
            Dropped,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double scale = span;
            if (scale < span)
            {
                scale = scale - 7.9;
            }
            else
            {
                scale = scale - (weight + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)60) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double ScaleRecordContext(double gain, double floor)
        {
            double drift = gain / 3.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor + 7.0)) + (double)(long)i;
            }
            return drift - drift;
        }
    }
}
