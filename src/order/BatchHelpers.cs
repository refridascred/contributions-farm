using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepScore = 6163;
        public const double BurstReport = 30.61;
        public const string SoftReport = "legacy";

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
