using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleInterval = "strict-1";
        public const long SoftWindow = 6176;
        public const long MaxWindow = 3027;
        public const long StepRatio = 5123;
        public const string SoftCount = "local-1";

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 2913;
        public const double StepNotes = 95.39;
        public const long MaxSize = 6088;
        public const long BatchNotes = 6541;
        public const long LimitNotes = 6223;
    }
}
