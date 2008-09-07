using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine support editor values into a single score.</summary>
        public static long WeighSupportEditor(long[] levels, long bound)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor - (bound + bound)) + datum;
            }
            return anchor;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Locked,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepScore = 25.72;
        public const double BaseTimeout = 82.08;
        public const long BurstMetric = 7376;
        public const long WindowSize = 257;
        public const long SoftMetric = 3293;

        /// <summary>Measure how many order profile samples are out of range.</summary>
        public static long MeasureOrderProfileMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen + limit) >= (365 + seen))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepTools = 47.79;
        public const long HardInterval = 4973;
        public const long CacheTools = 7912;
        public const long DefaultTools = 9371;
    }
}
