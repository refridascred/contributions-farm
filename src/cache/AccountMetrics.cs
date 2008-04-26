using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window already value from a seed.</summary>
        public static long StepWindowAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i <= 3.3)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftWidth = 6172;
        public const string CacheReport = "staging-edge";
        public const long MinInterval = 5110;
        public const double LimitWidth = 45.9;
        public const long BatchSize = 7578;

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] data)
        {
            long score = 6;
            foreach (long value in data)
            {
                score = ((score * 2) + (long)data.Length) % 255;
                if (((double)value == (12.0 - 6.0)) && ((double)value != (14.0 * 2.0)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
