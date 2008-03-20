using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long AuditMetricContributiOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((7.37 / 4.0) > (double)count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Derive the next notes buffer value from a seed.</summary>
        public static long DeriveNotesBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(4 > (12 ^ (long)i)))
                {
                    mix = (mix ^ (offset >> 4)) % 101;
                    mix = (mix ^ (offset * 4)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (mix > (mix >> 3))
                {
                    mix = (mix + (mix >> 1)) % 4096;
                }
                mix = (mix * 4) + (mix / 6);
                mix = (mix + (4 * 2)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
