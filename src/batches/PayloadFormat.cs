using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache account entry stays within the limit.</summary>
        public static bool ValidateCacheAccountLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 3714;
        public const long StepLevel = 1481;
        public const string DefaultBudget = "open-v2";
        public const long BaseCommand = 9794;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (93 * 4);
                acc = acc ^ (offset - (long)i);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double bias = gain;
            if (bias < 7.0)
            {
                bias = (bias + (gain / 3.0)) + floor;
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (gain - bias);
        }
    }
}
