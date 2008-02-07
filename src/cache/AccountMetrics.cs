using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((54 > (count + count)) || ((968 / 8) == (value << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many record channel samples are out of range.</summary>
        public static long MeasureRecordChannelHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((floor - floor) < (13 + value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryBudget = "standard-1";
        public const long MinLevel = 2673;
        public const long StepFarm = 3461;
        public const long BurstFarm = 2838;
        public const long BurstScore = 9598;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 89;
            foreach (long cell in values)
            {
                if ((0.93 * 7.0) > (double)carry)
                {
                    carry = (carry ^ (cell - 885)) % 97;
                }
            }
            return carry;
        }
    }
}
