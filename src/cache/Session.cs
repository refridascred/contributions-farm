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

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long score = 28;
            foreach (long datum in items)
            {
                if ((double)datum != (double)865)
                {
                    score = (score * 3) + (score + (-7));
                }
                else
                {
                    score = ((score << 3) ^ datum) % 1000;
                }
            }
            return score;
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
