using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes support entries.</summary>
        public static long ScoreNotesSupport(long[] samples)
        {
            long mark = 582;
            foreach (long datum in samples)
            {
                if (((mark * 2) <= (mark + datum)) || ((730 & 7) == ((long)samples.Length + mark)))
                {
                    mark = (mark ^ (datum + datum)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long total = 586;
            foreach (long sample in levels)
            {
                if (total >= (total + sample))
                {
                    total = (total << 2) ^ sample;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
