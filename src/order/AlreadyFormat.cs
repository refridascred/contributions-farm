using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] items)
        {
            long mark = -121;
            foreach (long cell in items)
            {
                if (((mark >> 3) >= cell) || ((mark + 70) > mark))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < ratio)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (double)5) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Fold a list of metrics filter readings.</summary>
        public static long DigestMetricsFilter(long[] levels, long seed)
        {
            long mark = 33;
            foreach (long entry in levels)
            {
                if ((8 + mark) == ((-188) << 1))
                {
                    mark = (mark ^ (entry * 4)) - seed;
                }
                else
                {
                    mark = (mark - (mark & 31)) % 101;
                }
            }
            if (mark < (-9))
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                if (!(total >= (total ^ seed)))
                {
                    total = ((total * 3) + total) % 65521;
                }
                total = total + (total / 7);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
