using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] readings, long seed)
        {
            long sum = 111;
            foreach (long cell in readings)
            {
                if ((cell >> 2) != (seed - sum))
                {
                    sum = (sum << 3) ^ seed;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + 919);
                }
            }
            return sum % 97;
        }

        /// <summary>Audit metrics record readings against a rule.</summary>
        public static long MeasureMetricsRecordGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((346 - hits) < hits)
                {
                    hits = ((hits + 2) - value) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
