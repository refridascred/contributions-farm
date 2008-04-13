using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double mean = ratio * 8.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (offset * 6.8)) - (double)(long)i;
            }
            return mean + (3.0 * 2.0);
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
