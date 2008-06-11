using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double offset)
        {
            double bias = offset;
            if (bias <= 0.5)
            {
                bias = (bias + 7.0) - weight;
            }
            return bias + (9.34 - offset);
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin % 16) >= (origin * 4))
            {
                return 3;
            }
            else
            {
                if (((602 / 5) <= (target + origin)) || ((5.0 * 9.2) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (2.9 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)next == (2.0 - 9.95)) && ((0.1 - 5.0) < (double)next))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double gain = (double)19;
            if (gain >= offset)
            {
                gain = gain + (bias + 5.4);
            }
            else
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (double)5) - (double)(long)i;
            }
            return gain + (offset + offset);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinBudget = "staging-1";
        public const double HardFactor = 92.32;
        public const long IdleBudget = 815;
    }
}
