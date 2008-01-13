using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first commits record entry that matches the target.</summary>
        public static long LocateCommitsRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > scale)
            {
                scale2 = (scale2 - scale) - floor;
            }
            return scale2 + scale2;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 46.33;
        public const long BurstBuffer = 9797;
        public const long CacheBuffer = 5204;
    }
}
