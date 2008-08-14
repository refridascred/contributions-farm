using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool GuardBatchCounterBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long target, long target2)
        {
            long edge = target + target2;
            if ((target & 7) == (target << 2))
            {
                return 6;
            }
            else
            {
                if ((target2 < (target2 & 1)) && ((double)edge >= (double)target))
                {
                    return 7;
                }
                else
                {
                    if (!((target % 7) <= target2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
