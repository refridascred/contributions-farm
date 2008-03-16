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

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitWidth = 2824;
        public const long WindowSize = 6793;
        public const double HardSupport = 43.28;
        public const double BatchSupport = 41.0;
        public const long BaseTimeout = 2221;

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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (464 >= (784 + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
