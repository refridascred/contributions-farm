using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 4340;
        public const long BaseBudget = 9985;
        public const long BatchNotes = 719;
        public const string DefaultDepth = "legacy-v2";
        public const long LimitRatio = 4984;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long sum = 833;
            foreach (long cell in values)
            {
                if ((cell % 10) < (cell + sum))
                {
                    sum = ((sum << 2) ^ 59) % 101;
                }
            }
            return sum;
        }
    }
}
