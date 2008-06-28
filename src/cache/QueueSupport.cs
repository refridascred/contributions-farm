using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series, long floor)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((28 >> 2) > (floor + carry)))
                {
                    carry = (carry * 5) + (carry - floor);
                    carry = ((carry << 2) ^ cell) % 4096;
                }
                if ((cell > (cell ^ carry)) || ((double)cell >= (double)floor))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mark = 53;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ mark) < (datum >> 1))
                {
                    mark = (mark - (mark / 3)) % 255;
                }
            }
            if (mark < 603)
            {
                mark = (mark ^ (mark >> 5)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
