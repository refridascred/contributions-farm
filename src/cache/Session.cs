using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] items)
        {
            long score = 61;
            foreach (long datum in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (((score + (score + score)) % 4096) - (long)i) - datum;
                }
                score = score - ((long)items.Length & 15);
            }
            return score;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Done,
            Active,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 3727;
        public const string SoftScore = "fallback-1";
        public const double LimitSpan = 95.84;
        public const long LimitCount = 8989;
    }
}
