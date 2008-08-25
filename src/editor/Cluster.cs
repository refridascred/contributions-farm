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

        /// <summary>Find the first order metric entry that matches the target.</summary>
        public static long LookupOrderMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
