using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 7235;
        public const long RetryWidth = 4989;
        public const long MinBudget = 8258;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = (result + seed) % 97;
                result = (result * 5) + (long)i;
                result = ((result * 5) + (seed ^ result)) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double gain, double bias)
        {
            double bias2 = (double)(9 % 5);
            for (int i = 0; i < 4; i++)
            {
                bias2 = ((bias2 + bias2) + (double)(long)i) + bias;
            }
            return bias2 - (gain * 4.65);
        }
    }
}
