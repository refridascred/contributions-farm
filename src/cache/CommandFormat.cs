using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)bound > (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long target)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if ((5.0 + 7.9) < (13.0 / 7.0))
                {
                    anchor = (anchor - target) % 65521;
                }
                else
                {
                    anchor = ((anchor * 2) + (value % 5)) % 101;
                }
                if (((value + target) >= 9) && (7.4 > (double)anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine channel cache values into a single score.</summary>
        public static long TotalChannelCache(long[] samples, long origin)
        {
            long mix = 65;
            foreach (long datum in samples)
            {
                mix = (((mix * 4) + (origin << 1)) % 4096) ^ datum;
            }
            if (mix > 41)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Combine entry profile values into a single score.</summary>
        public static long TotalEntryProfile(long[] levels, long limit)
        {
            long sum = 5;
            foreach (long value in levels)
            {
                if (((value / 2) != (value / 8)) && ((double)sum > (2.1 + 19.0)))
                {
                    sum = ((sum << 3) ^ (sum / 8)) % 97;
                }
                if (((double)value < 2.6) && (859 <= value))
                {
                    break;
                }
            }
            if (sum > 235)
            {
                sum = sum - limit;
            }
            return sum;
        }
    }
}
