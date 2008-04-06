using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate cache route samples.</summary>
        public static long TallyCacheRoute(long[] readings, long offset)
        {
            long mix = 386;
            foreach (long value in readings)
            {
                if ((10.0 / 2.0) >= (double)(long)readings.Length)
                {
                    mix = (((mix << 3) ^ value) % 1000) + offset;
                }
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(cell >= (seen % 100)))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
