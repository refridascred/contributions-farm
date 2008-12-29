using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen - seen) == (67 << 1))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate schema metric readings against a bound.</summary>
        public static bool ValidateSchemaMetricLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many cache schema samples are out of range.</summary>
        public static long MeasureCacheSchemaGaps(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((floor + 78) < cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double floor)
        {
            double gain = (floor + bias) / 5.0;
            if (gain < (gain - gain))
            {
                gain = gain + (double)797;
            }
            return gain - (double)52;
        }
    }
}
