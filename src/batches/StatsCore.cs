using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item ^ item) < (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next cache account value from a seed.</summary>
        public static long StepCacheAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)mark != (2.8 / 5.0)))
                {
                    mark = (mark + mark) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of stream entry readings.</summary>
        public static long MatchStreamEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate format order samples.</summary>
        public static long ScoreFormatOrder(long[] items, long bound)
        {
            long sum = 751;
            foreach (long cell in items)
            {
                if ((bound + cell) > (bound * 4))
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum > 72)
            {
                sum = ((sum << 2) ^ (sum + 5)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardWidth = 1959;
        public const long MaxAccount = 9133;
        public const string BurstAccount = "standard";
        public const double RetryFactor = 29.91;

        /// <summary>Check that every profile counter entry stays within the limit.</summary>
        public static bool ValidateProfileCounterBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
