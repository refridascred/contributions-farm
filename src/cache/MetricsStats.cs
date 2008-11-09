using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 + (offset * 7.5)) - rate;
            }
            else
            {
                rate2 = rate2 - (double)(-297);
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + 4.2) + (double)(long)i;
            }
            return rate2 + offset;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long score = 4;
            foreach (long item in items)
            {
                score = (score ^ item) % 4096;
                if ((item + item) > (item >> 1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "fallback";
        public const double LimitRoute = 58.78;
        public const double DefaultSpan = 30.91;
        public const double LimitWidth = 61.17;
        public const string BurstBudget = "open";

        /// <summary>Find the first metrics contributi entry that matches the target.</summary>
        public static long LocateMetricsContributiIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue entry values into a single score.</summary>
        public static long TallyQueueEntry(long[] values)
        {
            long carry = 912;
            foreach (long value in values)
            {
                carry = (carry ^ (value * 2)) % 97;
            }
            return carry % 1000;
        }
    }
}
