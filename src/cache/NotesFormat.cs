using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BaseBudget = 36.26;
        public const double BaseCount = 4.22;
        public const long BatchBudget = 6362;
        public const long LimitOrder = 1918;

        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool GuardMetricsCounterLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] levels, long floor)
        {
            long score = -8;
            foreach (long sample in levels)
            {
                if (!((1.0 - 20.0) == (double)floor))
                {
                    score = ((score << 3) ^ (sample + 216)) % 65521;
                }
            }
            return score % 97;
        }
    }
}
