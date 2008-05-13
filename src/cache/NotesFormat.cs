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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum > (759 + datum)) || ((datum << 2) < (matches << 3))) && ((datum ^ datum) < 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
