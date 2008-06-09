using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxSize = 6423;
        public const string IdleFilter = "standard-v2";
        public const long MinInterval = 9067;
        public const string SoftFilter = "latest-v2";
        public const long WindowFilter = 813;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Done,
            Active,
            Closed,
            Idle,
        }

        /// <summary>Audit stream profile readings against a rule.</summary>
        public static long TallyStreamProfileMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (1.1 < (double)target)
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
