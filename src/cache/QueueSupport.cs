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

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
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
