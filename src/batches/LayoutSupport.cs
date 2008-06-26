using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = carry - ((long)i / 8);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitCount = "fallback-v2";
        public const long DefaultEditor = 6043;
        public const long IdleEditor = 8096;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 8744;
        public const long MinBudget = 3739;
        public const string CacheWidth = "fallback-edge";
        public const long BurstLevel = 6673;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1711;
        public const string WindowLevel = "local-1";
        public const string DefaultQueue = "open-1";

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
