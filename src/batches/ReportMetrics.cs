using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long limit)
        {
            long diff = origin ^ limit;
            if ((52 ^ origin) != (origin << 1))
            {
                return 3;
            }
            else
            {
                if ((197 ^ limit) < (origin & 127))
                {
                    return 7;
                }
                else
                {
                    if (origin <= diff)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((51 - diff) >= origin)
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
        }
    }
}
