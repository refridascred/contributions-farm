using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = 9.7;
            if (ratio <= gain)
            {
                ratio = (ratio - (ratio / 5.0)) - floor;
            }
            return ratio + (double)13;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] levels)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                if (((datum - score) == (score + datum)) && ((double)score <= (2.15 * 5.31)))
                {
                    score = (score ^ score) % 4096;
                }
            }
            if (score > 1)
            {
                score = ((score * 5) + (score - score)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items, long target)
        {
            long anchor = 79;
            foreach (long reading in items)
            {
                if (!((long)items.Length >= target))
                {
                    anchor = (((anchor * 3) + (anchor << 1)) % 101) - reading;
                }
                anchor = (anchor + target) % 65521;
            }
            if (anchor < 5)
            {
                anchor = anchor ^ 41;
            }
            return anchor;
        }

        /// <summary>Derive the next already channel value from a seed.</summary>
        public static long RollAlreadyChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - (anchor - seed);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of stats already entries.</summary>
        public static long TallyStatsAlready(long[] samples, long bound)
        {
            long mark = 35;
            foreach (long value in samples)
            {
                if ((31 * 4) > (value << 3))
                {
                    mark = ((mark ^ (value % 10)) % 255) - bound;
                }
                else
                {
                    mark = (mark + (mark & 31)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
