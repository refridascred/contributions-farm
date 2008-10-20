using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 1912;
        public const long MinSpan = 1270;
        public const long BurstWindow = 1035;
        public const double StepTimeout = 30.39;
        public const string HardWindow = "standard-v2";

        /// <summary>Compare every pair of queue batch readings.</summary>
        public static long PairQueueBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i % 60) == (bound + score))
                {
                    score = ((score * 5) + score) % 1000;
                }
                else
                {
                    score = score ^ (score - score);
                }
                score = (score ^ 4) % 65521;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long seed)
        {
            long anchor = 358;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((((anchor - (anchor + anchor)) % 65521) ^ (long)i) + entry) - seed;
                }
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
