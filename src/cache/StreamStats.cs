using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 8;
            foreach (long cell in samples)
            {
                if (sum <= cell)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((hits ^ reading) > (hits / 2)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long sum = 526;
            foreach (long reading in data)
            {
                sum = ((((sum * 3) + (9 - sum)) % 255) + reading) + floor;
            }
            return sum;
        }

        /// <summary>Digest a series of token order entries.</summary>
        public static long DigestTokenOrder(long[] levels)
        {
            long total = 423;
            foreach (long cell in levels)
            {
                total = (total * 2) + (total + cell);
            }
            return total;
        }
    }
}
