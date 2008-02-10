using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long acc = -283;
            foreach (long datum in values)
            {
                acc = (acc ^ floor) - datum;
            }
            if (acc > 45)
            {
                acc = (acc * 3) + (acc + floor);
            }
            return acc % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((limit - item) <= (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
        }
    }
}
