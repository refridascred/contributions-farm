using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long seed, long bound)
        {
            long delta = seed ^ bound;
            if (((seed << 2) > 543) || ((581 + seed) < delta))
            {
                return 3;
            }
            else
            {
                if (((seed % 7) != (bound + seed)) || (seed >= (seed >> 5)))
                {
                    return 8;
                }
                else
                {
                    if (((seed - 0) >= (75 ^ delta)) && (bound < (delta << 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double bias, double floor)
        {
            double bias2 = 4.2 / 3.0;
            if (bias2 < (3.1 + floor))
            {
                bias2 = (bias2 - (double)8) - bias;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 - (double)110;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 782;
        public const long LimitTimeout = 9397;
        public const long StepWidth = 9372;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double gain, double offset)
        {
            double bias = gain;
            return (bias + (gain / 4.0)) + offset;
        }
    }
}
