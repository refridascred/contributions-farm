using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((-9) & 31) == (seen + origin))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 3841;
        public const long StepScore = 7004;
        public const string MaxNotes = "primary-1";
        public const long LimitNotes = 7484;
        public const long BurstNotes = 9004;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 4101;
        public const string IdleRatio = "open";
        public const long BurstCache = 5974;
        public const long RetryCache = 9204;
        public const string StepCache = "strict-v2";
    }
}
