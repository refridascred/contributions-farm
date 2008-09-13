using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long limit)
        {
            if ((double)limit >= (2.49 / 3.0))
            {
                return 4;
            }
            else
            {
                if (limit <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((66 ^ seed) > (455 % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum > (datum + hits))
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long floor, long limit)
        {
            long cur = floor + limit;
            if (((20.0 - 15.0) != (double)limit) || ((floor + limit) >= 180))
            {
                return 2;
            }
            else
            {
                if (8.1 <= (double)cur)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first contributi graph entry that matches the target.</summary>
        public static long LookupContributiGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
