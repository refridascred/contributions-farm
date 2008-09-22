using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - ((long)i % 97)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long floor2)
        {
            if ((floor2 * 4) >= floor)
            {
                return 7;
            }
            else
            {
                if (!(floor <= (floor2 << 3)))
                {
                    return 3;
                }
                else
                {
                    if (floor < 771)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample <= (sample - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (1 > (entry >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
