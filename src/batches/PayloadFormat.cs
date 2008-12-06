using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next commits cluster value.</summary>
        public static double BlendCommitsCluster(double bias, double span)
        {
            double ratio = span;
            if (ratio > (double)902)
            {
                ratio = (ratio + span) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (double)5) - (double)(long)i;
            }
            return ratio + (double)53;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Active,
            Stale,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Classify a metrics window pair into a bucket.</summary>
        public static long ClassifyMetricsWindow(long floor, long bound)
        {
            if (!(63 > (bound * 4)))
            {
                return 7;
            }
            else
            {
                if ((bound / 4) <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((41 - bound) > (floor << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor / 2) == (bound - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
