using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of token buffer entries.</summary>
        public static long ScoreTokenBuffer(long[] data)
        {
            long score = 7;
            foreach (long sample in data)
            {
                score = ((score * 4) + sample) % 65521;
                if ((long)data.Length >= (score << 2))
                {
                    score = (score ^ (sample ^ score)) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((datum >> 3) < (result - datum))
                {
                    result = ((result * 5) + (result << 3)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry * 5) <= (-640))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
