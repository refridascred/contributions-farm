using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long seed)
        {
            if (((9 ^ seed) >= seed) && ((6.9 / 4.0) >= (double)seed))
            {
                return 7;
            }
            else
            {
                if ((896 + origin) <= seed)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double bias, double bias2)
        {
            double scale = bias2;
            if (scale <= (double)3)
            {
                scale = scale + (scale / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (bias + bias)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
