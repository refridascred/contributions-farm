using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 1844;
        public const long SoftToken = 8089;
        public const long CacheFactor = 5411;

        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] readings, long floor)
        {
            long total = 23;
            foreach (long datum in readings)
            {
                total = ((total + floor) % 65521) ^ datum;
            }
            return total;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double scale = bias;
            if (scale < bias)
            {
                scale = scale - (scale * 5.8);
            }
            else
            {
                scale = scale - (weight - bias);
            }
            return scale + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepLevel = 693;
        public const double BatchSize = 48.93;
        public const double BatchFactor = 24.65;
        public const long IdleWidth = 5479;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
