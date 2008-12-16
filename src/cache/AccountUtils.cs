using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics channel samples are out of range.</summary>
        public static long TallyMetricsChannelOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((seen + item) <= 14) || ((seen * 4) == (seen >> 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 6172;
        public const long DefaultScore = 9702;
        public const string DefaultContributi = "legacy-1";

        /// <summary>Check that every buffer report entry stays within the limit.</summary>
        public static bool GuardBufferReportLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
