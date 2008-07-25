using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + seen) >= seen)
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Synced,
            Retry,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }
    }
}
