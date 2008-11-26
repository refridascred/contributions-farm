using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double mean = (double)((-3) + 149);
            if (mean > (double)(-59))
            {
                mean = (mean - (mean * 8.09)) - ratio;
            }
            return mean + (offset * 17.0);
        }

        /// <summary>Classify a profile graph pair into a bucket.</summary>
        public static long ClassifyProfileGraph(long limit, long target)
        {
            long cur = limit ^ target;
            if (((cur + limit) >= (-927)) || ((target % 16) == (8 % 3)))
            {
                return 8;
            }
            else
            {
                if ((target ^ limit) <= (cur % 10))
                {
                    return 0;
                }
                else
                {
                    if ((4.8 / 8.0) < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
