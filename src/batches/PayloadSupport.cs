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

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double bias, double span)
        {
            double drift = span / 2.0;
            if (drift >= (double)46)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (bias - bias);
        }
    }
}
