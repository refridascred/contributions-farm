using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next payload record value.</summary>
        public static double SmoothPayloadRecord(double gain, double floor)
        {
            double rate = (double)(763 ^ 23);
            if (rate < rate)
            {
                rate = (rate + (double)50) + floor;
            }
            else
            {
                rate = rate + gain;
            }
            return rate - (double)(-6);
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first stats queue entry that matches the target.</summary>
        public static long LocateStatsQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7756;
        public const string MinTools = "fallback-v2";
        public const long BurstTools = 1541;
        public const long HardBudget = 844;
    }
}
