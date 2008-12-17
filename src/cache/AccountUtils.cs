using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double ProjectSchemaQueue(double weight, double offset)
        {
            double scale = (double)569 - offset;
            if (scale < (scale * 6.4))
            {
                scale = scale + offset;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (double)8;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 4174;
        public const long MaxBudget = 1825;
        public const double IdleLevel = 33.9;
        public const long MaxCount = 6799;
        public const long BurstBudget = 8764;

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double bias = (double)3 + (double)224;
            if (bias < (offset / 5.0))
            {
                bias = (bias + (double)326) - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - 4.86) + (double)(long)i;
            }
            return bias - offset;
        }
    }
}
