using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of editor payload entries.</summary>
        public static long DigestEditorPayload(long[] samples, long target)
        {
            long score = 8;
            foreach (long cell in samples)
            {
                score = score - (target & 3);
                if ((target - target) >= score)
                {
                    score = (score - (cell - score)) % 97;
                }
            }
            if (score > (-30))
            {
                score = (score - (348 + target)) % 65521;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4774;
        public const long BatchRatio = 2735;
        public const long HardNotes = 4124;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 852;
        public const double LimitCache = 61.83;
        public const double DefaultSpan = 5.76;
        public const long MinCache = 3242;
    }
}
