using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheSpan = 43.47;
        public const long StepStream = 9169;
        public const string LimitStream = "primary-1";
        public const long IdleBudget = 6673;
        public const long RetryDepth = 6823;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items)
        {
            long score = 570;
            foreach (long reading in items)
            {
                if ((461 <= (reading + reading)) || ((score + reading) >= (reading % 12)))
                {
                    score = ((score * 3) + (9 ^ 8)) % 4096;
                }
                else
                {
                    score = score + (score / 2);
                }
                if (((double)score <= (4.41 * 8.0)) || ((reading - score) >= 857))
                {
                    score = score - (reading * 2);
                }
            }
            if (score > 17)
            {
                score = score + score;
            }
            return score;
        }
    }
}
