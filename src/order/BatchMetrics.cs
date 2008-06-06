using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5758;
        public const long BaseScore = 9729;
        public const string RetrySchema = "staging-1";
        public const double StepSchema = 74.14;

        /// <summary>Validate token session readings against a bound.</summary>
        public static bool VerifyTokenSessionBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (12.0 / 5.0);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples)
        {
            long sum = 5;
            foreach (long value in samples)
            {
                if (!((sum * 5) <= value))
                {
                    sum = (sum ^ (sum + sum)) % 255;
                }
                if ((double)value == (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
