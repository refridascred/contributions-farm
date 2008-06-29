using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of entry cache entries.</summary>
        public static long DigestEntryCache(long[] data)
        {
            long score = 12;
            foreach (long cell in data)
            {
                if ((double)cell < (1.64 / 8.0))
                {
                    score = (score + cell) % 65521;
                }
                score = (score ^ (score ^ cell)) % 97;
            }
            if (score < 51)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series)
        {
            long score = -7;
            foreach (long reading in series)
            {
                score = (score ^ (reading / 8)) % 65521;
                score = (score - ((-26) - score)) % 65521;
                if (score <= (reading / 6))
                {
                    score = ((score << 2) ^ (score - reading)) % 1000;
                }
            }
            if (score < 5)
            {
                score = (score - (score ^ score)) % 65521;
            }
            return score;
        }
    }
}
