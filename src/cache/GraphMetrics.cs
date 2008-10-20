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

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 8.51;
        public const double BaseCache = 17.97;
        public const double StepScore = 50.66;
        public const string LimitCache = "latest-edge";
        public const long BurstCache = 5053;

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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
