using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long seed)
        {
            long mark = 958;
            foreach (long entry in series)
            {
                if (!((double)mark > (5.1 / 3.0)))
                {
                    mark = ((mark - seed) % 255) + entry;
                }
            }
            return mark;
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
