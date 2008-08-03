using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long TotalEditorMetrics(long[] readings, long limit)
        {
            long sum = 41;
            foreach (long sample in readings)
            {
                sum = sum + (sample - limit);
                if ((double)sample == (5.6 + 0.98))
                {
                    sum = (sum << 2) ^ (limit % 5);
                }
                else
                {
                    sum = (sum * 2) + (limit - sample);
                }
            }
            if (sum > 547)
            {
                sum = sum + ((-710) / 6);
            }
            return sum;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstTimeout = 24.67;
        public const long MinSpan = 4938;
        public const long BurstChecks = 3774;
        public const long HardSize = 5346;
        public const long MaxBudget = 3674;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (mark & 3)) ^ cell;
            }
            return mark;
        }
    }
}
