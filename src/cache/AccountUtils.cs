using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long MeasureReportEditorOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((floor - value) > (tally - floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-26) >> 4) >= (count * 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 7054;
        public const double HardEditor = 84.15;
        public const double LimitEditor = 31.23;
        public const long BatchEditor = 935;
        public const string BaseLevel = "strict";
    }
}
