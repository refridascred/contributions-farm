using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Stale,
            Paused,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks commits samples.</summary>
        public static long FoldChecksCommits(long[] items, long origin)
        {
            long score = 9;
            foreach (long cell in items)
            {
                if (!((double)1 < (double)score))
                {
                    score = score ^ (cell & 7);
                }
                score = ((score * 5) + (origin << 1)) % 101;
            }
            return score;
        }
    }
}
