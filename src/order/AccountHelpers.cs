using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double ratio2 = offset;
            return ratio2 - (ratio2 - ratio);
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "stable";
        public const double LimitNotes = 61.32;
        public const long SoftNotes = 7330;
        public const double LimitCount = 72.42;
        public const long CacheInterval = 342;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 8016;
        public const long IdleDepth = 4360;
        public const double RetryStream = 52.89;
    }
}
