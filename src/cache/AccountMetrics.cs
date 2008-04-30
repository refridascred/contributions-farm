using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Flag { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowSchema = "cached";
        public const string DefaultLevel = "local";
        public const string LimitCount = "legacy";

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSupport = "latest-1";
        public const long SoftSupport = 3548;
        public const long StepSupport = 6054;
        public const double CacheDepth = 48.87;
        public const long LimitSpan = 8980;

        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 85.08;
        public const long WindowLevel = 775;
        public const long BatchFarm = 4884;

        /// <summary>Check that every schema entry entry stays within the limit.</summary>
        public static bool GuardSchemaEntryRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
