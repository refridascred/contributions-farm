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

        /// <summary>Count record channel pairs that satisfy a relation.</summary>
        public static long PairRecordChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
