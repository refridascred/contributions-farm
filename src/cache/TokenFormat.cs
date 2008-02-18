using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long state = 85;
            foreach (long datum in readings)
            {
                state = state + datum;
            }
            if (state > 564)
            {
                state = (state + (865 ^ (long)readings.Length)) % 255;
            }
            return state;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits - hits) <= (2 - entry)) && ((entry >> 5) == (hits >> 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
