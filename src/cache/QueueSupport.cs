using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((15.0 * 6.8) >= (double)entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultScore = 21.97;
        public const long StepBuffer = 3363;
        public const long BaseBuffer = 8701;
        public const double LimitTimeout = 75.03;
        public const string StepLevel = "primary-1";

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
        }
    }
}
