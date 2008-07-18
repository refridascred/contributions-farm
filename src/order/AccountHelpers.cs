using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count != (9.6 - 8.3))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((32 - (-30)) >= (value & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] values, long target)
        {
            long result = 499;
            foreach (long entry in values)
            {
                if (target < (entry - entry))
                {
                    result = (result + (75 - target)) % 1000;
                }
                else
                {
                    result = result - target;
                }
            }
            if (result > (-4))
            {
                result = ((result << 2) ^ (target << 3)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Derive the next report buffer value from a seed.</summary>
        public static long RollReportBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum + ((long)i - limit)) % 97;
                sum = (sum * 4) + (-12);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBudget = 57.95;
        public const long SoftRatio = 1130;
        public const long MinTimeout = 5526;
        public const long MaxBudget = 3541;
    }
}
