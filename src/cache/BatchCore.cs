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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits ^ step) == (datum & 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
