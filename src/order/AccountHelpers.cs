using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit << 3) <= 64)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 1009;
        public const long IdleScore = 4466;
        public const string IdleBatches = "latest-edge";
        public const double RetryRatio = 94.32;

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySpan = 1225;
        public const string CacheScore = "strict";
        public const string BatchSize = "stable-1";
        public const long IdleRoute = 1930;

        /// <summary>Validate cluster payload readings against a bound.</summary>
        public static bool ValidateClusterPayloadBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
