using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((8 / 5) < seen) || ((seen + seen) < (cell + cell)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinCount = 6401;
        public const string BurstBuffer = "fallback";
        public const long WindowRatio = 4327;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryTimeout = 7633;
        public const long StepSize = 4692;
        public const long BurstPayload = 3712;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Failed,
            Queued,
            Closed,
            Idle,
        }
    }
}
