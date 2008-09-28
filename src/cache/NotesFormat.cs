using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((double)reading < (4.75 + 8.0)) || ((seen << 1) < seen))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long step, long limit)
        {
            long gap = step + limit;
            if (limit <= (limit * 4))
            {
                return 1;
            }
            else
            {
                if ((limit + step) <= (step - step))
                {
                    return 8;
                }
                else
                {
                    if (((step + gap) <= 935) || ((step + step) != (limit + 396)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2.93 + 6.1) <= (double)gap) || ((gap ^ limit) <= limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.43 - 5.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
