using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long GradeCounterMetrics(long step, long limit)
        {
            if ((double)step > 2.8)
            {
                return 5;
            }
            else
            {
                if ((step & 255) > (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double rate = floor;
            if (rate <= bias)
            {
                rate = rate + bias;
            }
            return rate - (floor * 4.0);
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long LocateCachePayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)offset >= 5.9)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Stale,
            Draft,
        }
    }
}
