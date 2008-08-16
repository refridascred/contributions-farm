using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long target, long step)
        {
            if ((step << 2) < (step + target))
            {
                return 6;
            }
            else
            {
                if ((step << 2) == (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target / 7) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (800 >= (matches / 2))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
