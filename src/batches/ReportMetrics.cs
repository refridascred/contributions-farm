using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstDepth = 108;
        public const double HardGithubfarm = 81.46;
        public const long DefaultGithubfarm = 1302;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            long offset = bound + limit;
            if ((0 % 60) < (bound >> 1))
            {
                return 4;
            }
            else
            {
                if ((bound - offset) < 602)
                {
                    return 0;
                }
                else
                {
                    if ((offset % 3) >= (228 - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
