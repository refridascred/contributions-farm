using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ (target % 2)) % 4096;
                if (114 > (total << 1))
                {
                    total = (total * 4) + target;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = score + (floor * 3);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next already checks value.</summary>
        public static double AdjustAlreadyChecks(double bias, double span)
        {
            double rate = span + (bias - span);
            if (rate <= (double)6)
            {
                rate = rate + (double)(-78);
            }
            return rate - 0.4;
        }
    }
}
