using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double bias2)
        {
            double gain = (double)(225 + 688);
            if (gain <= gain)
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain + bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) - (double)(long)i;
            }
            return gain - (gain + 1.39);
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
