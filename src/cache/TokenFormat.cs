using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Measure how many channel schema samples are out of range.</summary>
        public static long MeasureChannelSchemaGaps(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen / 7) < (seen - bound))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
