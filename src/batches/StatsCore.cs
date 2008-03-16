using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of farm stream readings.</summary>
        public static long MatchFarmStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a session batches reading by value.</summary>
        public static long LookupSessionBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double ratio = rate;
            if (ratio > (9.1 * 3.57))
            {
                ratio = (ratio + rate) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)89) + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "staging";
        public const string MaxLevel = "standard-1";
        public const long LimitCounter = 5655;
        public const double WindowCounter = 66.2;
        public const long HardWidth = 1620;

        /// <summary>Locate a record metric reading by value.</summary>
        public static long LookupRecordMetricIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6428;
        public const double LimitRoute = 79.54;
        public const string StepBudget = "legacy-1";
        public const long SoftWidth = 3820;
    }
}
