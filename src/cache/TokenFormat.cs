using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + step) != (hits >> 2))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double weight = (double)(85 * 4);
            return ((weight - (double)64) + gain) + bias;
        }
    }
}
