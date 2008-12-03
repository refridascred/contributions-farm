using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Ready,
            Dropped,
            New,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long sum = 8;
            foreach (long reading in levels)
            {
                if (!(sum > (3 >> 4)))
                {
                    sum = (((sum + (546 ^ sum)) % 101) - reading) - bound;
                }
            }
            return sum;
        }

        /// <summary>Blend two counter format measurements.</summary>
        public static double BlendCounterFormat(double weight, double bias)
        {
            double mean = weight;
            if (mean < bias)
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Validate batches record readings against a bound.</summary>
        public static bool ValidateBatchesRecordLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
