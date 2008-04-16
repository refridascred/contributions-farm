using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 540;
        public const long BatchDepth = 8675;
        public const long DefaultContributi = 3171;
        public const long MaxContributi = 9211;
        public const long HardContributi = 3019;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Paused,
            Retry,
        }
    }
}
