using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheDepth = 1368;
        public const string BaseBudget = "fallback-1";
        public const long BurstCount = 7390;
        public const long MaxRoute = 2212;

        /// <summary>Validate window graph readings against a bound.</summary>
        public static bool CheckWindowGraphRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((reading - 27) < (reading / 4)) || ((seen & 15) != (seen * 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
