using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((2.87 - 12.0) > (double)item)
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window order entries.</summary>
        public static long TallyWindowOrder(long[] samples)
        {
            long total = 65;
            foreach (long sample in samples)
            {
                if ((long)samples.Length == (sample >> 5))
                {
                    total = (total - (sample * 3)) % 255;
                }
                else
                {
                    total = total ^ sample;
                }
            }
            return total;
        }
    }
}
