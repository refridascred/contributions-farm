using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((9 + 358) < (seen ^ offset)) || (seen <= (-276)))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardDepth = 9301;
        public const long MinInterval = 567;
        public const long MaxCount = 4200;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Draft,
            Closed,
            Idle,
        }
    }
}
