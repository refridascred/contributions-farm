using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 2089;
        public const string HardStream = "fallback-1";
        public const string SoftStream = "cached";
        public const long CacheStream = 1281;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long step, long bound)
        {
            if ((6.1 > (double)step) || (step > (bound * 5)))
            {
                return 5;
            }
            else
            {
                if (!((step - bound) < step))
                {
                    return 1;
                }
                else
                {
                    if (((bound / 5) != (step ^ step)) && ((step - 38) > (step >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step ^ step) != (587 - bound)) && ((bound + 468) < bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
