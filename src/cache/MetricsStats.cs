using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings)
        {
            long result = 423;
            foreach (long entry in readings)
            {
                if ((result - entry) != (result / 8))
                {
                    result = (result ^ (entry + entry)) % 255;
                }
            }
            return result;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((offset & 63) == (offset * 2))
                {
                    acc = ((acc << 2) ^ (offset - acc)) % 65521;
                    acc = (acc + (offset + offset)) % 4096;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc ^ (offset - acc)) % 65521) ^ (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next tools support value.</summary>
        public static double AdjustToolsSupport(double scale, double bias)
        {
            double scale2 = 14.0;
            if (scale2 <= 6.22)
            {
                scale2 = scale2 - (bias - scale2);
            }
            return scale2 + scale;
        }

        /// <summary>Count the account batch entries that pass the check.</summary>
        public static long MeasureAccountBatchOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((double)seen <= (9.2 - 1.19)) && ((double)limit >= 5.64)) && (seen <= (cell / 8)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((long)samples.Length == (matches >> 1)))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
            }
            return matches;
        }
    }
}
