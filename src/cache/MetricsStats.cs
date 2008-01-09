using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double weight, double floor)
        {
            double bias = weight;
            if (bias >= 7.41)
            {
                bias = bias - (floor - weight);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias - (7.1 * 9.13);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((-50) + cell) >= (seen - 43))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] samples, long floor)
        {
            long total = 291;
            foreach (long reading in samples)
            {
                if ((total >> 4) < (reading + floor))
                {
                    total = (total - (total ^ floor)) % 1000;
                }
            }
            return total;
        }
    }
}
