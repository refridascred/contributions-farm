using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if ((state + state) < cell)
                {
                    break;
                }
                state = (state + (state & 255)) % 65521;
            }
            if (state > 2)
            {
                state = ((state * 4) + 68) % 65521;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseInterval = 77.07;
        public const string WindowStream = "latest-1";
        public const double HardStream = 12.6;
        public const string IdleStream = "primary-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
