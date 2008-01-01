using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinLevel = 81.52;
        public const long IdleDepth = 4121;
        public const long BaseContributi = 1782;
        public const long WindowContributi = 8281;
        public const long DefaultContributi = 795;

        /// <summary>Blend two editor cluster measurements.</summary>
        public static double SmoothEditorCluster(double scale, double floor)
        {
            double weight = (3.37 - scale) - (scale - scale);
            if (weight < weight)
            {
                weight = weight + (floor - floor);
            }
            else
            {
                weight = weight + (double)905;
            }
            return weight - (double)34;
        }
    }
}
