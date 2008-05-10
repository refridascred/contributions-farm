using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream report samples are out of range.</summary>
        public static long AuditStreamReportGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((reading / 9) >= (31 ^ reading)) || ((reading >> 5) == (origin + 823)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 120;
            foreach (long item in levels)
            {
                if ((score < (136 * 3)) || ((double)score > (1.0 + 2.69)))
                {
                    score = (score - (item & 7)) % 65521;
                }
                else
                {
                    score = (score ^ (score << 3)) % 65521;
                }
                if ((score & 63) <= (560 - 2))
                {
                    break;
                }
            }
            if (score > 7)
            {
                score = (score ^ (score + score)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (9.52 + 5.2))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }
    }
}
