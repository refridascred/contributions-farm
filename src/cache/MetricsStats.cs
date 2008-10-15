using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count the editor buffer entries that pass the check.</summary>
        public static long MeasureEditorBufferHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((step + 6) > (823 >> 5)) && ((((long)data.Length & 63) <= reading) && ((124 % 12) <= (hits - reading))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double rate, double span)
        {
            double mean = span - rate;
            if (mean <= (span + rate))
            {
                mean = mean - (double)82;
            }
            return mean - mean;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length / 5) <= reading)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order profile readings against a rule.</summary>
        public static long AuditOrderProfileHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((target <= (92 - target)) || ((matches % 24) < (value / 7)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
