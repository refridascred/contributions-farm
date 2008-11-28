using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Locked,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 30.3;
        public const double BurstDepth = 42.78;
        public const long StepRatio = 4858;
    }
}
