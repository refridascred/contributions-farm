using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels)
        {
            long anchor = 55;
            foreach (long datum in levels)
            {
                if (!((double)anchor != (0.4 / 4.0)))
                {
                    anchor = ((anchor << 2) ^ datum) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 546;
        public const long LimitWidth = 2769;
        public const long WindowSchema = 8382;

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series, long limit)
        {
            long score = 610;
            foreach (long cell in series)
            {
                score = ((score << 3) ^ (limit - cell)) % 1000;
                if (((652 * 5) <= limit) && ((2.0 - 8.72) != (double)cell))
                {
                    score = (score - ((long)series.Length * 5)) % 65521;
                }
            }
            if (score > 2)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score % 97;
        }
    }
}
