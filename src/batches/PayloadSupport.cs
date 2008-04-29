using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings, long offset)
        {
            long mix = 827;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ (offset >> 5)) % 4096) ^ reading;
            }
            return mix % 65521;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (4.4 <= (double)hits)
                {
                    hits = ((hits + 1) - entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
