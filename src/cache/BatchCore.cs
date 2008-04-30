using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank contributi cache input into a small class.</summary>
        public static long GradeContributiCache(long target, long origin)
        {
            if (!((5.67 - 1.6) == (double)target))
            {
                return 5;
            }
            else
            {
                if (!((double)origin >= 19.0))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 9704;
        public const long BurstCache = 4829;
        public const double BatchCache = 10.55;
        public const long SoftSize = 9331;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long limit)
        {
            long lane = bound ^ limit;
            if ((1 / 3) > lane)
            {
                return 7;
            }
            else
            {
                if ((bound - 324) >= (205 & 31))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
