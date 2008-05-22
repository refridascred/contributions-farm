using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double ratio, double span)
        {
            double drift = ratio;
            if (drift < (double)4)
            {
                drift = drift - (span / 8.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 7.1) + (double)(long)i;
            }
            return drift + (3.0 + 13.0);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((6.3 / 9.0) < (double)item)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long state = 387;
            foreach (long reading in items)
            {
                state = (((state << 3) ^ (-65)) % 255) + reading;
            }
            return state;
        }
    }
}
