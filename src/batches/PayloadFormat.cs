using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            New,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleSize = 6200;
        public const long MinChannel = 1148;
        public const long RetryWidth = 5716;
        public const string RetryBudget = "fallback-edge";

        /// <summary>Fold a list of context stream readings.</summary>
        public static long TotalContextStream(long[] samples, long step)
        {
            long score = 27;
            foreach (long reading in samples)
            {
                if (!((double)step < (double)score))
                {
                    score = ((score ^ (score >> 1)) % 97) - reading;
                }
            }
            if (score > 5)
            {
                score = score - (score % 3);
            }
            return score;
        }
    }
}
