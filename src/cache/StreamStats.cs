using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepScore = 3641;
        public const long BatchRatio = 7113;
        public const long BatchContributi = 8705;

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Paused,
            Failed,
            Synced,
        }

        /// <summary>Check that every filter account entry stays within the limit.</summary>
        public static bool VerifyFilterAccountBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
