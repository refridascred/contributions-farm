using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 53.46;
        public const long MaxDepth = 7216;
        public const long RetryContext = 1732;
        public const long MinSpan = 8157;
    }
}
