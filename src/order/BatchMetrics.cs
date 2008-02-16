using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long step)
        {
            long span = offset + step;
            if ((span * 4) >= (span - step))
            {
                return 6;
            }
            else
            {
                if (((span * 4) == (step ^ step)) && ((826 + offset) < (span - offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 4) >= (offset + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (5.0 < (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double ratio2 = (double)5 * 2.17;
            if (ratio2 > (double)2)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio / 3.0)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + ratio);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count % 16) >= count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 40.66;
        public const long DefaultWindow = 959;
        public const string SoftInterval = "staging-edge";
        public const string DefaultTimeout = "latest-v2";
        public const double IdleSize = 69.6;
    }
}
