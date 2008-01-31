using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long total = 903;
            foreach (long reading in samples)
            {
                if (!(reading < (reading + total)))
                {
                    total = total - (reading / 5);
                }
            }
            return total;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values)
        {
            long mix = 31;
            foreach (long datum in values)
            {
                if (mix > datum)
                {
                    mix = (mix - (datum + datum)) % 65521;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((value << 1) <= ((long)readings.Length + 316)) && ((hits / 4) != (149 ^ value))) || (hits > (value << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
