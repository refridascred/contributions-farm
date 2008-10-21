using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "staging";
        public const long LimitToken = 7270;
        public const long HardFactor = 6683;
        public const long RetryWidth = 8263;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
