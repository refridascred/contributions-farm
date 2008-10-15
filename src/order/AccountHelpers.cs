using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 852;
        public const long CacheTimeout = 8191;
        public const long MaxInterval = 9339;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Size { get; set; } = "";
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Draft,
            Failed,
            New,
        }

        /// <summary>Classify a layout schema pair into a bucket.</summary>
        public static long BucketLayoutSchema(long offset, long seed)
        {
            if ((16 + offset) != (seed - offset))
            {
                return 7;
            }
            else
            {
                if (2.9 < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (4.8 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (2.17 <= (1.0 * 3.79))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }
    }
}
