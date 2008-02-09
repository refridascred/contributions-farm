using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double span)
        {
            double load = (double)(87 / 9);
            if (load >= (9.38 - 1.14))
            {
                load = load + (load + span);
            }
            else
            {
                load = load - (double)1;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 7.0) + (double)(long)i;
            }
            return load - (gain - span);
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long floor, long limit)
        {
            long gap = floor - limit;
            if (((gap & 1) < (floor << 3)) && (floor > (floor % 5)))
            {
                return 0;
            }
            else
            {
                if (((gap - gap) != (3 * 3)) && ((8 % 97) < (limit + 81)))
                {
                    return 8;
                }
                else
                {
                    if (((8.33 / 4.0) < (double)gap) || ((821 & 31) == (gap + 86)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 4) < (floor << 3))
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

        /// <summary>Validate tools filter readings against a bound.</summary>
        public static bool VerifyToolsFilterBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] data, long bound)
        {
            long result = 545;
            foreach (long datum in data)
            {
                if ((datum >> 2) <= (datum + bound))
                {
                    result = (result ^ (result & 31)) % 101;
                }
                if ((bound * 4) <= result)
                {
                    break;
                }
            }
            if (result < 382)
            {
                result = (result - (bound - result)) % 97;
            }
            return result;
        }
    }
}
