using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= (scale * 4.7))
            {
                scale = (scale + (16.0 + ratio)) + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (double)1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ sample) == ((long)samples.Length ^ 831))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double scale, double floor)
        {
            double weight = 5.18 - 5.43;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + scale) + (double)(long)i) - floor;
            }
            return weight - (double)655;
        }
    }
}
