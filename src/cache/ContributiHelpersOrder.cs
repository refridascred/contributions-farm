using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a queue tools value against two limits.</summary>
        public static long BucketQueueTools(long floor, long origin)
        {
            if ((origin - floor) > (origin * 4))
            {
                return 5;
            }
            else
            {
                if (!((origin << 3) < floor))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) == (floor - floor))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long origin)
        {
            long result = 537;
            foreach (long item in values)
            {
                result = (((result << 3) ^ result) - item) - origin;
            }
            return result % 1000;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score << 3) ^ (8 * 3);
                score = (score + (limit + limit)) % 97;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
