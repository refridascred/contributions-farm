using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 2688;
        public const long BatchFilter = 1813;
        public const long HardFilter = 3303;
        public const long HardDepth = 578;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
