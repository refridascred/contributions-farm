using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Done,
            Retry,
            New,
            Synced,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long acc = 8;
            foreach (long reading in samples)
            {
                if (!((seed * 5) == (reading + seed)))
                {
                    acc = (acc + (seed + 840)) % 97;
                }
                else
                {
                    acc = (acc - 780) % 101;
                }
            }
            if (acc > 576)
            {
                acc = (acc + 495) % 97;
            }
            return acc;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Closed,
            Locked,
            Failed,
            Draft,
        }
    }
}
