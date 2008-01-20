using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes graph entries that pass the check.</summary>
        public static long MeasureNotesGraphGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((((hits + 7) == (reading + target)) && ((reading - reading) == (target >> 3))) || ((reading - hits) != (hits + 25)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if ((item ^ score) >= (-751))
                {
                    score = score - score;
                }
                else
                {
                    score = (score * 3) + (score - item);
                }
            }
            if (score < (-84))
            {
                score = score + score;
            }
            return score % 97;
        }
    }
}
