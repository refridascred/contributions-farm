using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cluster queue input into a small class.</summary>
        public static long GradeClusterQueue(long floor, long origin)
        {
            if ((1 & 15) > (origin << 1))
            {
                return 4;
            }
            else
            {
                if (((8.88 + 2.0) >= (double)11) || ((6 - floor) <= (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((21 + floor) <= 5)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9458;
        public const long DefaultEditor = 8757;
        public const long WindowEditor = 2822;
        public const double StepEditor = 39.47;

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long seed)
        {
            if (((double)seed != (3.97 - 2.0)) || ((double)seed < (4.0 * 15.0)))
            {
                return 1;
            }
            else
            {
                if ((4.65 > (double)limit) || ((limit ^ limit) < (limit / 6)))
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
}
