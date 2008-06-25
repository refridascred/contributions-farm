using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 7735;
        public const long HardSpan = 76;
        public const long CacheSpan = 1188;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
