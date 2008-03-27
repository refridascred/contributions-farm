using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((bound - 413) <= (2 * 2))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (((target + bound) != (39 & 3)) && ((bound << 3) <= (bound - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((19.0 / 7.0) == (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinWidth = "legacy-edge";
        public const long BaseTools = 2740;
        public const string SoftDepth = "alpha-1";
        public const long MaxSize = 376;
        public const double MaxScore = 83.88;
    }
}
