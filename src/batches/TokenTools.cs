using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 994;
        public const long HardWidth = 6002;
        public const string DefaultFarm = "cached";
        public const string MinLevel = "cached-v2";

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + value) != (matches ^ matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
