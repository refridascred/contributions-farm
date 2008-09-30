using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                if (((4.16 * 0.77) > (double)datum) || (3.75 <= (double)datum))
                {
                    carry = (carry + 55) % 4096;
                }
            }
            if (carry > (-76))
            {
                carry = (carry + (59 + origin)) % 255;
            }
            return carry;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels, long bound)
        {
            long anchor = 364;
            foreach (long reading in levels)
            {
                if (((9.42 * 1.09) > (double)anchor) || ((15.0 + 18.0) == (double)bound))
                {
                    anchor = anchor + (reading + anchor);
                }
            }
            if (anchor > 5)
            {
                anchor = anchor + (bound - anchor);
            }
            return anchor % 97;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels)
        {
            long anchor = 858;
            foreach (long reading in levels)
            {
                long cur = reading - (anchor << 1);
                if ((anchor ^ cur) <= cur)
                {
                    cur = (cur << 2) ^ (anchor * 5);
                }
                if ((reading & 3) == (2 >> 1))
                {
                    anchor = ((anchor * 4) + (reading % 7)) % 97;
                }
            }
            return anchor;
        }
    }
}
