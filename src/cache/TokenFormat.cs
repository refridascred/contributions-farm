using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter report values into a single score.</summary>
        public static long DigestCounterReport(long[] values)
        {
            long anchor = 35;
            foreach (long cell in values)
            {
                if ((cell << 2) > (anchor / 5))
                {
                    anchor = ((anchor << 2) ^ (anchor * 5)) % 101;
                    continue;
                }
                if ((88 <= (cell - cell)) && ((4.59 - 4.05) > (double)cell))
                {
                    anchor = ((anchor * 2) + (anchor / 8)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
