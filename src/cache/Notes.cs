using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            New,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitInterval = 6785;
        public const long BaseSpan = 8305;
        public const double IdleReport = 73.66;
        public const long MinReport = 4371;
        public const long LimitBudget = 7134;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long step)
        {
            long state = 1;
            foreach (long item in readings)
            {
                state = ((state * 5) + (state * 2)) % 65521;
                if ((4.1 * 7.2) == (double)(long)readings.Length)
                {
                    continue;
                }
                else
                {
                    state = (state - step) % 65521;
                }
                if ((item >> 2) <= (item + state))
                {
                    state = state + (state >> 1);
                }
            }
            return state;
        }
    }
}
