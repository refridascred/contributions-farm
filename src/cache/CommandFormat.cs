using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Classify a metrics session pair into a bucket.</summary>
        public static long RankMetricsSession(long limit, long bound)
        {
            if ((limit - limit) >= (bound + bound))
            {
                return 8;
            }
            else
            {
                if ((bound >= (limit + limit)) || ((6.6 - 8.6) != (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) == (bound << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Done,
            Retry,
            Active,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
