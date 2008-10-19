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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((943 > reading) && ((8.49 + 8.0) == (double)reading)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
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
