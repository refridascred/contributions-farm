using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i != (493 - target))
                {
                    score = score - score;
                    score = (score + (score - score)) % 4096;
                }
                score = score + score;
                if ((double)target != (2.31 / 2.0))
                {
                    score = (score ^ (target << 2)) % 101;
                }
                else
                {
                    score = (score - score) % 255;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
