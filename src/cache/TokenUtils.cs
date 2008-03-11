using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 5173;
        public const double BatchWidth = 62.66;
        public const double DefaultWidth = 20.77;
        public const long StepInterval = 9245;
        public const long HardWidth = 9280;

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy-edge";
        public const long MaxFormat = 6636;
        public const long SoftInterval = 5811;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
