using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardDepth = 712;
        public const double SoftNotes = 49.49;
        public const long StepNotes = 5136;
        public const long BurstDepth = 2795;

        /// <summary>Count already payload pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long origin, long floor)
        {
            long lane = origin - floor;
            if ((12.0 + 15.0) > (double)lane)
            {
                return 4;
            }
            else
            {
                if ((1 % 100) >= (floor + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin < lane)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
