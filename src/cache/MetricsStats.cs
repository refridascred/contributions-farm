using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepWidth = 445;
        public const long BurstAlready = 5739;
        public const long DefaultAlready = 1341;
        public const double StepFactor = 96.56;

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long seed)
        {
            if ((double)seed >= (1.0 - 2.05))
            {
                return 1;
            }
            else
            {
                if ((3.46 + 6.51) == (double)target)
                {
                    return 2;
                }
                else
                {
                    if (seed < (target - 36))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
