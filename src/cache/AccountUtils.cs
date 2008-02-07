using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] readings, long floor)
        {
            long mix = 744;
            foreach (long datum in readings)
            {
                if (floor > (mix / 7))
                {
                    mix = (mix - (9 % 16)) + datum;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count the batches report entries that pass the check.</summary>
        public static long MeasureBatchesReportOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)109 > (double)reading)
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Audit metric report readings against a rule.</summary>
        public static long TallyMetricReportHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum >> 3) >= (long)items.Length) && !((count ^ (-682)) < (datum + count)))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }
    }
}
