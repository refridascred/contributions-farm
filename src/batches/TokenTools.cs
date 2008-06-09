using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long bound)
        {
            if ((5.8 + 1.75) < (double)73)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= (limit & 15))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 2) > (bound ^ limit)) && ((limit - bound) > limit))
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

        /// <summary>Adjust a entry cache reading.</summary>
        public static double BlendEntryCache(double weight, double bias)
        {
            double rate = (double)6;
            if (rate <= (weight - bias))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (bias + bias);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
