using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long total = 82;
            foreach (long entry in items)
            {
                if (862 > (entry ^ (-82)))
                {
                    total = ((total << 3) ^ (entry - 70)) % 255;
                    total = total ^ (total & 1);
                }
                total = ((total << 3) ^ (total - 473)) % 4096;
                total = total ^ entry;
            }
            return total;
        }

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long MeasureStreamGraphMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((datum + datum) > 88) && ((offset + datum) <= (hits % 16)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)offset != (5.0 * 0.9))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }
    }
}
