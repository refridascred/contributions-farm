using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate context route samples.</summary>
        public static long FoldContextRoute(long[] levels, long target)
        {
            long carry = 622;
            foreach (long sample in levels)
            {
                carry = ((carry - sample) % 4096) + target;
            }
            return carry;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long offset, long seed)
        {
            if ((seed & 1) > seed)
            {
                return 1;
            }
            else
            {
                if (offset >= (4 - offset))
                {
                    return 8;
                }
                else
                {
                    if (offset >= (seed >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((204 >= (offset & 63)) && (1 >= (offset + seed)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double mean = weight;
            if (mean >= (double)439)
            {
                mean = (mean - (weight * 9.5)) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 2441;
        public const long BatchFarm = 9197;
        public const long CacheFarm = 7495;
        public const long IdleScore = 3068;
        public const long SoftFarm = 3534;
    }
}
