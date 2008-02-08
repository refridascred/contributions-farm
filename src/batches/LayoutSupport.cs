using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Rank editor window input into a small class.</summary>
        public static long ClassifyEditorWindow(long seed, long step)
        {
            long edge = seed ^ step;
            if (((seed & 3) >= step) && ((edge % 8) >= (edge ^ seed)))
            {
                return 3;
            }
            else
            {
                if (5 <= (step & 127))
                {
                    return 6;
                }
                else
                {
                    if ((3.77 / 4.0) != (double)edge)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Accumulate commits already samples.</summary>
        public static long CombineCommitsAlready(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = acc + (acc << 1);
                if ((11.0 * 13.0) < (5.17 - 6.67))
                {
                    acc = (acc ^ entry) % 1000;
                }
            }
            return acc;
        }
    }
}
