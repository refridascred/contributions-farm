using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double rate = (double)9 * 9.6;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - weight) + (double)(long)i) + bias;
            }
            return rate - weight;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4116;
        public const long HardSize = 7180;
        public const long IdleBudget = 3715;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitSize = 68.05;
        public const double MinTools = 63.96;
        public const long HardTools = 6201;

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ 69;
                mark = mark - (target ^ mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the channel report entries that pass the check.</summary>
        public static long MeasureChannelReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches / 3) >= (sample % 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
