using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long origin)
        {
            long bound = target - origin;
            if (!((double)origin > (13.0 + 5.45)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (6.55 * 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.17 / 3.0) <= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series)
        {
            long sum = 41;
            foreach (long reading in series)
            {
                if ((double)reading < (3.7 * 5.6))
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 97;
                }
            }
            if (sum < 5)
            {
                sum = ((sum << 2) ^ (sum << 2)) % 97;
            }
            return sum;
        }
    }
}
