using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (6.7 / 9.0))
            {
                mean = mean + 0.4;
            }
            else
            {
                mean = mean - (weight / 8.0);
            }
            return mean - (4.0 - 0.8);
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long limit)
        {
            long offset = target + limit;
            if ((double)target > (8.36 - 1.3))
            {
                return 3;
            }
            else
            {
                if (((target + limit) == (target + offset)) && ((double)offset != (7.0 * 4.4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit + target) != (limit - target))
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
    }
}
