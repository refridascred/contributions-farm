using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardToken = "fallback-edge";
        public const long IdleToken = 4908;
        public const long MinBudget = 7070;
        public const double BatchInterval = 23.62;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Retry,
            Locked,
            Active,
            Queued,
        }
    }
}
