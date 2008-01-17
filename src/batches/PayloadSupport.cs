using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 8438;
        public const long StepRatio = 6375;
        public const long WindowFormat = 3714;

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 65.13;
        public const long RetryGraph = 2733;
        public const long HardGraph = 4233;
        public const double SoftTimeout = 14.37;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
