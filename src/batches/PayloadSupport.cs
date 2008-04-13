using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a metric counter pair into a bucket.</summary>
        public static long GradeMetricCounter(long limit, long limit2)
        {
            if ((limit2 * 4) <= (limit + limit2))
            {
                return 2;
            }
            else
            {
                if ((646 >> 1) != (410 - limit2))
                {
                    return 3;
                }
                else
                {
                    if ((3 % 64) > (limit + 855))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit > limit2)
                        {
                            return 6;
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
