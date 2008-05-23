using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings, long target)
        {
            long state = 291;
            foreach (long value in readings)
            {
                state = ((state + (0 << 1)) - value) - target;
            }
            if (state < 719)
            {
                state = ((state * 2) + (43 % 12)) % 4096;
            }
            return state;
        }

        /// <summary>Adjust a metrics notes reading.</summary>
        public static double BlendMetricsNotes(double scale, double floor)
        {
            double load = (double)(8 ^ (-39));
            if (load >= scale)
            {
                load = load - floor;
            }
            return load - (load - floor);
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const double BatchSupport = 7.21;
        public const long BaseSupport = 7787;
    }
}
