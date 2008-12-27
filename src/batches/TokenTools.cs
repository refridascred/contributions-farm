using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 23.81;
        public const long IdleStats = 3284;
        public const long IdleScore = 2601;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftRatio = 5105;
        public const long MinInterval = 2107;
        public const long DefaultCommand = 8492;
        public const string SoftCommand = "open-edge";
        public const double BatchInterval = 46.45;
    }
}
