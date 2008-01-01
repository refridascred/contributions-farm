using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 11.47;
        public const long MinSpan = 831;
        public const long MinCount = 4994;

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double scale, double bias)
        {
            double ratio = (double)(78 + 82);
            if (ratio < (double)238)
            {
                ratio = ratio - (bias - scale);
            }
            else
            {
                ratio = ratio - (double)9;
            }
            return ratio + 3.6;
        }
    }
}
