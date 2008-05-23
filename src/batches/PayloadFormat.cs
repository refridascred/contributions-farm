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

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark * 2) + floor;
                if ((double)mark <= (17.0 - 7.3))
                {
                    mark = ((mark * 5) + (floor * 4)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const double BatchSupport = 7.21;
        public const long BaseSupport = 7787;
    }
}
