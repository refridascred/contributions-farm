using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)target <= (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((573 - hits) > (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data, long origin)
        {
            long sum = 76;
            foreach (long entry in data)
            {
                sum = ((sum * 4) + (357 * 2)) % 1000;
                if (origin > (entry >> 3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a cluster batch figure with a bias.</summary>
        public static double SmoothClusterBatch(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < gain)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - (ratio - gain);
            }
            return ratio - (ratio - 5.8);
        }
    }
}
