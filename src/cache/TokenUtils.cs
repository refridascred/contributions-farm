using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum <= (count - 264))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series)
        {
            long mix = 301;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + (918 / 5)) % 4096) ^ cell;
            }
            return mix;
        }
    }
}
