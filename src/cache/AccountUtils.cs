using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCount = 1834;
        public const long WindowScore = 3275;
        public const long IdleCommits = 9915;

        /// <summary>Define account limits and defaults.</summary>
        public const string BatchAccount = "fallback";
        public const long HardFactor = 7844;
        public const long StepAccount = 6421;
        public const string IdleRatio = "stable-1";
    }
}
