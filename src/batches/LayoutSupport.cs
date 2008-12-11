using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepRatio = 9936;
        public const long RetryLayout = 655;
        public const long HardLevel = 9834;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((target < (target & 31)) || ((matches - matches) <= item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support record readings.</summary>
        public static long CompareSupportRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long offset, long bound)
        {
            long diff = offset - bound;
            if (!(486 >= (diff + bound)))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) <= diff))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
