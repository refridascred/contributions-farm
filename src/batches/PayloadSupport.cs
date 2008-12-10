using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] items, long floor)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ floor) + cell;
            }
            return mark % 4096;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
