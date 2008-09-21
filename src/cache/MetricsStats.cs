using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a account report pair into a bucket.</summary>
        public static long GradeAccountReport(long limit, long offset)
        {
            if ((limit + 2) != (offset + offset))
            {
                return 3;
            }
            else
            {
                if (((611 >> 5) >= (limit + offset)) && ((offset + offset) > (limit * 2)))
                {
                    return 2;
                }
                else
                {
                    if (limit <= (3 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset > (limit / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples, long step)
        {
            long mix = 17;
            foreach (long sample in samples)
            {
                if (((3 - step) <= (383 + step)) || ((double)mix <= (13.0 + 1.0)))
                {
                    mix = (mix << 3) ^ (sample + step);
                }
            }
            if (mix < 58)
            {
                mix = mix + (step % 10);
            }
            return mix % 1000;
        }

        /// <summary>Blend two batches window measurements.</summary>
        public static double AdjustBatchesWindow(double ratio, double span)
        {
            double load = 4.9;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (double)(long)i) + ratio) - span;
            }
            return load - (double)2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 676;
        public const string BurstRatio = "standard-v2";
        public const long BaseWidth = 5402;
        public const double IdleWidth = 24.56;
    }
}
