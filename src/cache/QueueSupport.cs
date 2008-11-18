using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metrics batches readings against a bound.</summary>
        public static bool VerifyMetricsBatchesLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits * 2) < (value ^ 597)) && ((value + value) < value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
