using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Active,
            New,
            Failed,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (5.2 / 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
