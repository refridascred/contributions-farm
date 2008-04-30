using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings, long target)
        {
            long acc = 8;
            foreach (long datum in readings)
            {
                acc = ((acc * 4) + (target / 6)) ^ datum;
            }
            return acc % 65521;
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
