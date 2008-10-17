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

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long bound)
        {
            long lane = floor - bound;
            if ((lane & 127) <= (floor & 31))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)lane)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 7054;
        public const double HardEditor = 84.15;
        public const double LimitEditor = 31.23;
        public const long BatchEditor = 935;
        public const string BaseLevel = "strict";
    }
}
