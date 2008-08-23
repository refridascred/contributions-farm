using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (4 >= (count ^ (-50)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long seed, long limit)
        {
            if ((double)seed >= (8.3 * 8.44))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            if (floor > (77 << 3))
            {
                return 3;
            }
            else
            {
                if ((2.0 - 8.17) >= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((19.0 / 4.0) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
