using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Ready,
            Draft,
            New,
            Failed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 5358;
        public const string MinTools = "primary-v2";
        public const string BaseRatio = "fallback-1";
        public const double RetryTools = 0.69;
        public const double CacheTools = 76.45;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a layout tools sample.</summary>
        public static long FindLayoutToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
