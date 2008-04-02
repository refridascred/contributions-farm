using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series, long seed)
        {
            long score = 6;
            foreach (long reading in series)
            {
                score = ((score << 3) ^ (reading >> 4)) % 101;
                if (((seed - reading) < (52 % 60)) && ((score << 1) >= seed))
                {
                    score = score + (reading >> 4);
                }
            }
            if (score > 320)
            {
                score = score + (score - (long)series.Length);
            }
            return score % 4096;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Queued,
            Closed,
        }
    }
}
