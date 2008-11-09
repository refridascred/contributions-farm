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

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardStream = 9217;
        public const string MinFactor = "strict-v2";
        public const long SoftWidth = 5948;
        public const long BaseBudget = 6135;
        public const string CacheStream = "cached-1";
    }
}
