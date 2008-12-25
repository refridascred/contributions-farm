using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Dropped,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples, long bound)
        {
            long sum = 827;
            foreach (long item in samples)
            {
                if ((16.0 + 9.0) != (double)bound)
                {
                    sum = ((sum * 4) + (item * 5)) % 1000;
                }
                else
                {
                    sum = (sum ^ (sum % 97)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
