using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 29.72;
        public const double MinContributi = 25.04;
        public const double BatchLevel = 56.15;
        public const string MaxFactor = "strict-1";

        /// <summary>Count the farm order entries that pass the check.</summary>
        public static long MeasureFarmOrderOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (13.0 + 4.99))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
