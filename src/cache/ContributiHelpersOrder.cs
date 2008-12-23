using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxBudget = 2206;
        public const double BurstSpan = 43.81;
        public const long SoftSize = 52;
        public const long WindowCluster = 815;

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
