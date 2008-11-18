using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((reading ^ seen) < seen) && !(reading >= (seen / 8)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Token { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
