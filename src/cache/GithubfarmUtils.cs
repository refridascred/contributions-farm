using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double scale = (span - 7.53) * 13.0;
            if (scale >= span)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale + gain)) - (double)(long)i;
            }
            return scale + 2.73;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double bias, double bias2)
        {
            double drift = (double)(0 + 9);
            if (drift < (bias2 - bias))
            {
                drift = drift + (bias2 / 7.0);
            }
            return drift + (bias - bias2);
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
