using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long target, long origin)
        {
            long edge = target + origin;
            if (((edge & 63) >= target) && (edge <= (target ^ target)))
            {
                return 2;
            }
            else
            {
                if (((double)target != (7.76 * 5.1)) && ((target + origin) == (edge / 7)))
                {
                    return 0;
                }
                else
                {
                    if ((origin > (edge / 6)) && ((double)edge <= (2.2 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target + target) <= origin) && ((edge % 64) > edge))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((0.22 + 6.23) != (double)offset) && (offset < matches)) || ((offset >= (43 % 100)) && ((item ^ 6) <= (matches * 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((858 ^ (-57)) > (matches / 7))
                {
                    matches = ((matches + 1) ^ datum) + limit;
                }
            }
            return matches;
        }
    }
}
