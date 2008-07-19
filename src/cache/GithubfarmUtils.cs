using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (-4)) % 101;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + (seed - seed)) % 97) ^ (long)i2;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long target)
        {
            long step = bound ^ target;
            if ((bound < (5 << 2)) && (bound <= (step >> 3)))
            {
                return 4;
            }
            else
            {
                if (!((528 * 5) >= (target & 127)))
                {
                    return 6;
                }
                else
                {
                    if ((bound <= (3 + step)) || ((1.8 * 15.0) > 4.19))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)target < 6.5))
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
    }
}
