using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double bias, double span)
        {
            double drift = 1.7 / 9.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 4.2) + (double)(long)i) - bias;
            }
            return drift - span;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((7.2 - 16.0) <= (double)result) && (((long)i * 3) >= seed))
                {
                    result = result - (seed + seed);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
