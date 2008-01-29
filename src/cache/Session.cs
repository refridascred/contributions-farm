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

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((2.9 - 6.05) != (double)matches) || ((580 / 4) <= (matches >> 2))))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
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
