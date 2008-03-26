using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8794;
        public const double SoftBudget = 23.3;
        public const double BaseScore = 89.72;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long floor)
        {
            long state = -5;
            foreach (long cell in items)
            {
                if (((long)items.Length % 3) >= cell)
                {
                    state = (state + cell) - floor;
                }
            }
            if (state > 321)
            {
                state = ((state << 3) ^ ((-46) ^ state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
