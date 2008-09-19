using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((0 * 5) == (origin & 63)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((double)count > (4.6 / 4.0)))
                {
                    count = ((count + 3) ^ reading) + bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items)
        {
            long result = 33;
            foreach (long sample in items)
            {
                result = (result + sample) % 101;
                if (result <= (466 >> 5))
                {
                    result = result - ((-3) >> 1);
                }
                if (!(result <= (45 - sample)))
                {
                    result = (result ^ (result * 2)) % 97;
                }
            }
            if (result > 620)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 4096;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double ratio, double offset)
        {
            double ratio2 = (ratio + ratio) - offset;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (ratio2 - ratio2)) + (double)(long)i;
            }
            return ratio2 + ratio2;
        }
    }
}
