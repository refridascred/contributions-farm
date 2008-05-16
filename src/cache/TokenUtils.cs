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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
