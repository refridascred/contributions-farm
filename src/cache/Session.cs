using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long target)
        {
            long slot = step + target;
            if ((target > (slot << 3)) || ((slot << 2) < (82 + step)))
            {
                return 5;
            }
            else
            {
                if ((slot << 1) != (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((step <= (slot - target)) || (step <= (target & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double mean = bias;
            if (mean < 4.81)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (12.0 - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (weight * 7.12)) + (double)(long)i;
            }
            return mean + (bias / 7.0);
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
