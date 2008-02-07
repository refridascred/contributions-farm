using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double ratio, double bias)
        {
            double mean = (double)(5 * 2);
            if (mean <= ratio)
            {
                mean = mean + (bias - 1.0);
            }
            return mean + ratio;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Synced,
            Stale,
            Active,
            New,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] items)
        {
            long sum = 265;
            foreach (long reading in items)
            {
                sum = (sum ^ (reading >> 3)) % 255;
            }
            if (sum > 7)
            {
                sum = (sum - 326) % 1000;
            }
            return sum;
        }

        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool VerifyChecksBatchesBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
