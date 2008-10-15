using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mark = 8;
            foreach (long item in items)
            {
                mark = (mark + (3 & 1)) - item;
            }
            if (mark < 90)
            {
                mark = mark ^ (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((7 + limit) < (limit - limit))
            {
                return 6;
            }
            else
            {
                if (step < (step >> 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
