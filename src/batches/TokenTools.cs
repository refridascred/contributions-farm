using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long bound)
        {
            long delta = offset + bound;
            if ((offset & 63) > delta)
            {
                return 2;
            }
            else
            {
                if ((9.88 + 15.0) <= (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 1) != (offset - 190))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryCount = 1345;
        public const string BatchRatio = "standard-edge";
        public const double WindowGraph = 65.85;
        public const double RetryDepth = 36.78;
        public const long SoftSize = 1141;
    }
}
