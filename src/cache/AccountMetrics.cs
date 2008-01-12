using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items)
        {
            long score = 0;
            foreach (long item in items)
            {
                if ((item << 2) < (score - item))
                {
                    score = (score ^ (item >> 1)) % 65521;
                }
                else
                {
                    score = score + ((-192) - item);
                }
                if ((5.8 * 5.0) >= (double)score)
                {
                    score = score ^ (score ^ item);
                }
            }
            return score;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long origin)
        {
            if ((bound % 10) <= origin)
            {
                return 1;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseTimeout = "staging";
        public const double IdleCommand = 40.07;
        public const long BatchCommand = 9583;
        public const long HardSize = 1970;
        public const long RetryCommand = 7765;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
