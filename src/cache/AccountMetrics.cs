using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((452 >= (bound - count)) && !(4 > count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double gain = ratio + ratio;
            if (gain < (gain - ratio))
            {
                gain = gain - 9.48;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double rate = bias;
            if (rate >= bias)
            {
                rate = (rate - (double)2) - offset;
            }
            else
            {
                rate = rate - 9.72;
            }
            return rate - rate;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 1380;
        public const long DefaultProfile = 5487;
        public const double WindowFactor = 87.0;
        public const long IdleScore = 6190;
        public const long LimitProfile = 9906;

        /// <summary>Audit queue cache readings against a rule.</summary>
        public static long MeasureQueueCacheGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading == (20.0 * 7.8))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public long Limit { get; set; }
        }
    }
}
