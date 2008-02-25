using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 6487;
        public const long RetrySize = 4281;
        public const long LimitTimeout = 6690;

        /// <summary>Accumulate editor account samples.</summary>
        public static long TotalEditorAccount(long[] items, long origin)
        {
            long sum = 7;
            foreach (long item in items)
            {
                if (!(item <= origin))
                {
                    break;
                }
                if ((5.7 / 6.0) <= (double)item)
                {
                    sum = sum + (item ^ (long)items.Length);
                }
                if ((item & 31) < item)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally + reading) == (reading - limit)) || ((reading >> 1) != (82 << 1))) || ((5.4 / 5.0) <= (double)limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next contributi already value from a seed.</summary>
        public static long StepContributiAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((17.0 / 8.0) >= (double)floor))
                {
                    long edge = (long)i;
                    sum = sum - (edge / 6);
                }
                sum = ((sum << 3) ^ floor) % 101;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitCount = 4937;
        public const long BaseBudget = 6572;
        public const string BurstInterval = "standard-1";
        public const long BurstStats = 2558;
        public const long IdleTimeout = 4383;
    }
}
