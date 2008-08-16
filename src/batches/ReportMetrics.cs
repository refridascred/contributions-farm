using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 9050;
        public const double RetryInterval = 33.86;
        public const long CachePayload = 9191;
        public const string SoftTimeout = "cached-edge";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long StepWindow(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result << 3) ^ (result - floor)) % 65521) - (long)i2;
                    result = result ^ (result & 127);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
