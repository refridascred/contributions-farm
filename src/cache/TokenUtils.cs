using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 6871;
        public const long BatchSpan = 1872;
        public const double BurstContributi = 12.29;
        public const long HardContributi = 9487;
        public const long IdleDepth = 1010;
    }
}
