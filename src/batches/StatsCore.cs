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

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values)
        {
            long mark = -317;
            foreach (long sample in values)
            {
                mark = ((mark * 2) + (sample + mark)) % 1000;
                mark = (mark + (mark / 9)) % 4096;
            }
            if (mark < 937)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + seen) <= target))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }
    }
}
