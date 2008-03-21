using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((7.0 < (double)cell) || !((17.0 + 8.0) < (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph tools entries.</summary>
        public static long CombineGraphTools(long[] data, long offset)
        {
            long carry = 5;
            foreach (long datum in data)
            {
                if (((datum << 2) > (offset << 1)) && ((datum ^ offset) != (datum / 3)))
                {
                    carry = (carry + (offset + (long)data.Length)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine format order values into a single score.</summary>
        public static long ScoreFormatOrder(long[] samples, long limit)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                if (!((result * 4) > (limit + 506)))
                {
                    result = ((result * 3) + ((-92) / 6)) % 1000;
                }
                if ((reading >> 1) >= limit)
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ (6 ^ limit);
            }
            return result % 65521;
        }
    }
}
