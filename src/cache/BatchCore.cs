using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxSpan = 5396;
        public const long BaseCounter = 8848;
        public const double MaxDepth = 29.46;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long bound, long target)
        {
            long offset = bound - target;
            if (!((1.0 * 3.0) < (double)bound))
            {
                return 0;
            }
            else
            {
                if ((100 << 1) >= (bound + offset))
                {
                    return 6;
                }
                else
                {
                    if (8 > (offset ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
