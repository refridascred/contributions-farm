using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
