using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank batch format input into a small class.</summary>
        public static long ClassifyBatchFormat(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (111 > floor)
            {
                return 4;
            }
            else
            {
                if (((floor - floor) < (bound2 + bound)) && ((bound2 * 5) <= floor))
                {
                    return 2;
                }
                else
                {
                    if ((bound * 4) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 3) != (70 & 31))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload buffer sample.</summary>
        public static long FindPayloadBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account order reading.</summary>
        public static double BlendAccountOrder(double bias, double floor)
        {
            double gain = floor;
            return (gain + (double)649) + bias;
        }
    }
}
