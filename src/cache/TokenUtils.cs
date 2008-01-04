using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool GuardMetricChecksLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                long matches = acc;
                matches = (matches - (long)i) % 255;
                acc = (acc + (matches + offset)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
