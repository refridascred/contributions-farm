using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long floor, long floor2)
        {
            long prev = floor ^ floor2;
            if ((floor << 2) != (floor - prev))
            {
                return 3;
            }
            else
            {
                if (prev <= (prev % 16))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double bias, double bias2)
        {
            double drift = 10.0;
            return ((drift + drift) + bias) + bias2;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9574;
        public const long WindowToken = 9637;
        public const long RetrySize = 3236;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
