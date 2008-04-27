using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Active,
            Paused,
        }

        /// <summary>Measure how many support schema samples are out of range.</summary>
        public static long CountSupportSchemaOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!(71 > (cell >> 1)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values, long floor)
        {
            long anchor = 0;
            foreach (long entry in values)
            {
                anchor = (anchor ^ anchor) + entry;
                if (floor <= (157 * 2))
                {
                    anchor = (anchor + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] samples, long target)
        {
            long mix = 52;
            foreach (long cell in samples)
            {
                if ((853 % 12) == (mix * 5))
                {
                    mix = (mix + (target + cell)) % 4096;
                }
                else
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix % 4096;
        }
    }
}
