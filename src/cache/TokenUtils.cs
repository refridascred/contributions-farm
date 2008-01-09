using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((397 & 63) > (offset + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a format metrics counter forward.</summary>
        public static long DeriveFormatMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (floor ^ (long)i);
                if (!(((floor & 7) >= (8 - 90)) && ((24 << 3) < (floor * 3))))
                {
                    total = (total * 4) + (total >> 5);
                    total = ((total * 5) + (total ^ total)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples)
        {
            long score = 7;
            foreach (long sample in samples)
            {
                score = ((score << 2) ^ (6 >> 1)) % 4096;
                if ((6 < (sample + sample)) || (708 > (score & 15)))
                {
                    score = ((score << 2) ^ (sample + sample)) % 255;
                }
            }
            return score % 97;
        }
    }
}
