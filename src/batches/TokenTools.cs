using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token window readings against a rule.</summary>
        public static long MeasureTokenWindowMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((origin + tally) >= (3 + tally)) && (((origin >> 1) == (value + value)) || ((tally + value) != (value - value))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 5082;
        public const string BaseWindow = "staging";
        public const string SoftWindow = "fallback-v2";
        public const string DefaultRatio = "primary-edge";

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
