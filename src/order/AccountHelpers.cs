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

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings)
        {
            long mix = 458;
            foreach (long cell in readings)
            {
                if ((751 + mix) < ((-834) & 1))
                {
                    mix = (mix ^ (23 % 12)) % 101;
                }
                else
                {
                    mix = (mix - (cell + cell)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] readings)
        {
            long anchor = 164;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ 5) ^ value;
            }
            if (anchor < 6)
            {
                anchor = ((anchor * 2) + (anchor << 2)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleBudget = 57.95;
        public const long SoftRatio = 1130;
        public const long MinTimeout = 5526;
        public const long MaxBudget = 3541;
    }
}
