using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first token farm entry that matches the target.</summary>
        public static long FindTokenFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 8651;
        public const double LimitDepth = 26.25;
        public const double LimitWidth = 81.59;
        public const long BatchQueue = 8629;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            if ((double)floor != (0.91 * 7.47))
            {
                return 7;
            }
            else
            {
                if (((seed + floor) <= (seed ^ (-343))) && (seed >= (floor / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((floor - floor) < (7 - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
