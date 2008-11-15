using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepLevel = 1380;
        public const double MaxPayload = 66.29;
        public const long IdlePayload = 3279;
        public const long DefaultBudget = 1106;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double load = (double)(86 << 1);
            if (load <= bias)
            {
                load = (load - (3.17 + 6.94)) - weight;
            }
            return load + load;
        }
    }
}
