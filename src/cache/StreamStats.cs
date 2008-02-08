using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length == (2.9 / 2.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Total { get; set; }
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell >= hits) || ((hits >> 3) < offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double rate = bias;
            if (rate < (bias * 7.4))
            {
                rate = (rate - (16.0 / 2.0)) + bias2;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)9) + (double)(long)i;
            }
            return rate + (double)(-555);
        }
    }
}
