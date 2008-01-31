using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double load = bias2;
            if (load >= (bias2 - bias2))
            {
                load = (load + (double)2) + bias;
            }
            else
            {
                load = load - (9.58 - 8.3);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 7.6) + (double)(long)i;
            }
            return load - (bias2 * 1.24);
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long target)
        {
            if ((limit & 63) >= target)
            {
                return 7;
            }
            else
            {
                if ((95 % 100) >= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
