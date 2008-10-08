using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long floor, long bound)
        {
            long edge = floor + bound;
            if ((double)bound < (20.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if ((double)364 < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (880 > (edge ^ bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double ratio, double offset)
        {
            double mean = (double)(371 >> 3);
            if (mean >= offset)
            {
                mean = mean + (ratio - 15.0);
            }
            else
            {
                mean = mean - 17.0;
            }
            return mean + offset;
        }
    }
}
