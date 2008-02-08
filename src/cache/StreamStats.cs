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

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double weight = span;
            if (weight < 9.9)
            {
                weight = weight + scale;
            }
            return weight + span;
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
