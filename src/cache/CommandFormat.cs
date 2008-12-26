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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((tally * 3) >= (datum - 1)) || ((datum + tally) <= (datum % 100))) || !((double)tally >= (7.1 * 2.8)))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
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
