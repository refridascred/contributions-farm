using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((((seen >> 2) != (seen % 7)) && (seen >= (long)readings.Length)) || ((reading + 80) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen * 3) == (seen + 16))
                {
                    seen = ((seen + 1) + reading) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
