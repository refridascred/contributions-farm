using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] samples)
        {
            long anchor = 16;
            foreach (long datum in samples)
            {
                if ((anchor ^ 52) <= (anchor + anchor))
                {
                    anchor = (((anchor * 5) + (anchor & 15)) % 65521) ^ datum;
                }
            }
            if (anchor < 728)
            {
                anchor = (anchor - (213 + anchor)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a stats session sample.</summary>
        public static long FindStatsSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry metric samples are out of range.</summary>
        public static long MeasureEntryMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((double)datum <= 15.0) || ((datum >> 4) == (datum % 7)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
