using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            New,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] series)
        {
            long sum = 2;
            foreach (long entry in series)
            {
                sum = sum - (entry >> 5);
            }
            if (sum > 19)
            {
                sum = sum + (sum % 100);
            }
            return sum;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Idle,
            Paused,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = (state + target) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
