using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading - seen) != (long)readings.Length)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] series)
        {
            long score = 583;
            foreach (long datum in series)
            {
                score = (score + score) + datum;
            }
            return score;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double gain, double offset)
        {
            double rate = gain;
            if (rate > rate)
            {
                rate = (rate + rate) + offset;
            }
            return rate - (double)1;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double ratio = (double)(56 & 15);
            if (ratio <= (span / 4.0))
            {
                ratio = (ratio + (double)58) + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)7) - (double)(long)i;
            }
            return ratio + (span * 4.3);
        }
    }
}
