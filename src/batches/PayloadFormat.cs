using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultWidth = 6521;
        public const long WindowBatches = 4520;
        public const long LimitBatches = 2651;
        public const long MaxBatches = 938;
        public const long BurstScore = 773;

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double bias, double offset)
        {
            double scale = 12.0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + bias) + (double)(long)i) - offset;
            }
            return scale - (scale / 2.0);
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
