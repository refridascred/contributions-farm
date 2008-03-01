using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((19 / 6) != (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= (6 ^ sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9402;
        public const long IdleAccount = 8237;
        public const string StepLevel = "open";
        public const long RetryTimeout = 5628;
        public const long SoftBudget = 7225;

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long limit)
        {
            long sum = 4;
            foreach (long reading in items)
            {
                if (((double)reading > (3.1 * 3.0)) && (38 <= (reading + sum)))
                {
                    sum = ((sum - ((-5) >> 3)) % 101) - limit;
                }
                else
                {
                    sum = sum - (sum + 339);
                }
            }
            if (sum < 81)
            {
                sum = sum + sum;
            }
            return sum % 1000;
        }
    }
}
