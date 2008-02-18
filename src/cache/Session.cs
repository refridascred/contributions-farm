using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Pending,
            Closed,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftRatio = 344;
        public const long MinTimeout = 7137;
        public const string StepDepth = "strict";
        public const long IdleWindow = 5233;

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long anchor = -7;
            foreach (long item in readings)
            {
                if ((item + item) != (704 * 5))
                {
                    anchor = (anchor << 3) ^ (anchor % 2);
                    anchor = (anchor * 5) + (758 & 1);
                }
                if (0 >= (item + item))
                {
                    anchor = anchor - (item - anchor);
                }
            }
            if (anchor < 27)
            {
                anchor = (anchor + (anchor % 60)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
