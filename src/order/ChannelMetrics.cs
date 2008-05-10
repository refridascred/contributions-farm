using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6124;
        public const double StepDepth = 63.3;
        public const long BurstSize = 8923;
        public const double RetryTools = 53.82;
        public const string BatchWidth = "standard-v2";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long target, long limit)
        {
            long bound = target ^ limit;
            if ((limit + target) < (target * 4))
            {
                return 0;
            }
            else
            {
                if (limit > (bound / 9))
                {
                    return 1;
                }
                else
                {
                    if ((target + limit) <= (bound + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)bound > (double)4) || ((535 << 2) > bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
