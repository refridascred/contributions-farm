using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 55.92;
        public const double WindowAccount = 27.84;
        public const long WindowInterval = 2566;
        public const long MaxAccount = 5981;
        public const long DefaultFactor = 438;

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count >= (count - reading))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }
    }
}
