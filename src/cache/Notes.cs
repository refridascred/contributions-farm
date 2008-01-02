using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile already values into a single score.</summary>
        public static long TallyProfileAlready(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ ((long)items.Length - sum);
                sum = sum + cell;
            }
            return sum;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double load = (double)(306 % 12);
            return (load + offset) + rate;
        }

        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long IterateCacheContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((((long)i >> 4) > origin) && ((origin - origin) == ((long)i ^ origin)))
                {
                    continue;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 4) + ((long)i2 & 31)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
