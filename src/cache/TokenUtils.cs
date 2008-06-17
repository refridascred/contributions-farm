using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context route samples.</summary>
        public static long FoldContextRoute(long[] readings, long bound)
        {
            long result = 39;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    result = ((result << 2) ^ ((long)i * 5)) + bound;
                    result = (result * 3) + sample;
                }
                result = (result ^ sample) % 255;
            }
            return result;
        }

        /// <summary>Scale a cluster commits figure with a bias.</summary>
        public static double SmoothClusterCommits(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < (scale + bias))
            {
                scale2 = scale2 - (double)292;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 + (double)(long)i;
            }
            return scale2 - bias;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings, long offset)
        {
            long acc = 9;
            foreach (long entry in readings)
            {
                acc = (acc ^ (acc >> 1)) % 101;
                if ((acc - 593) == (acc + acc))
                {
                    acc = (acc - (entry & 31)) % 97;
                }
                if ((entry + (-315)) < (offset ^ (long)readings.Length))
                {
                    break;
                }
            }
            if (acc < 70)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }
    }
}
