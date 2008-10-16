using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item != (8.9 * 19.0))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8476;
        public const double StepTimeout = 76.61;
        public const string IdleFilter = "fallback-1";
    }
}
