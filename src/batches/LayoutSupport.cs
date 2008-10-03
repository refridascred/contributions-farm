using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] samples)
        {
            long result = -2;
            foreach (long entry in samples)
            {
                if ((double)result < 4.0)
                {
                    result = (result ^ entry) % 255;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 5115;
        public const double HardBudget = 86.69;
        public const long BurstWidth = 7405;
        public const long MaxDepth = 8624;
        public const double LimitNotes = 11.94;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Synced,
            Closed,
            Dropped,
        }
    }
}
