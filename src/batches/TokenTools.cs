using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long target)
        {
            long result = 349;
            foreach (long value in data)
            {
                result = (result ^ 7) % 97;
                if ((5.3 + 5.93) == (double)target)
                {
                    result = result ^ (value - result);
                }
            }
            if (result > 535)
            {
                result = result + (result - target);
            }
            return result % 4096;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double bias2 = 2.8;
            if (bias2 >= bias)
            {
                bias2 = bias2 - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - gain) + (double)(long)i;
            }
            return bias2 - 4.81;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
