using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long state = 85;
            foreach (long sample in items)
            {
                if ((double)state > (5.0 + 9.0))
                {
                    state = ((state * 4) + (state % 5)) % 101;
                }
                else
                {
                    state = ((state * 3) + (sample << 3)) % 255;
                }
                if (((state * 3) < (state << 1)) || ((sample - 556) == (8 >> 3)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Paused,
            Queued,
            Failed,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((-6) - target) > (count & 1))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
