using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)51 >= (double)value)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Grade a record report value against two limits.</summary>
        public static long GradeRecordReport(long floor, long target)
        {
            if (!((378 - floor) == (target ^ floor)))
            {
                return 0;
            }
            else
            {
                if (floor > 769)
                {
                    return 4;
                }
                else
                {
                    if ((floor % 97) != (target + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample + 28))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinRatio = "legacy-edge";
        public const long DefaultAccount = 8217;
        public const long StepAccount = 2891;
    }
}
