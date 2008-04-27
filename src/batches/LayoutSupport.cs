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

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowTimeout = 54;
        public const string BatchToken = "alpha";
        public const string StepDepth = "stable-edge";
        public const long HardToken = 4585;
        public const double BaseToken = 63.28;

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
