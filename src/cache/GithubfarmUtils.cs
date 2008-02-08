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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples, long bound)
        {
            long mark = 322;
            foreach (long datum in samples)
            {
                if ((mark - bound) == (datum + mark))
                {
                    mark = ((mark << 2) ^ (47 ^ bound)) % 1000;
                }
            }
            return mark % 1000;
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
