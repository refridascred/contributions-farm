using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double weight = bias;
            return (weight - bias) + offset;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double gain, double offset)
        {
            double drift = 0.23 / 8.0;
            if (drift > (14.0 / 5.0))
            {
                drift = (drift + gain) + offset;
            }
            else
            {
                drift = drift + (11.0 / 7.0);
            }
            return drift - (double)386;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 6375;
        public const double BaseBudget = 70.07;
        public const long IdleSize = 864;
    }
}
