using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((item % 100) >= (item * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Draft,
            Done,
            Failed,
            Queued,
        }
    }
}
