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

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long bound, long offset)
        {
            long step = bound - offset;
            if (offset >= (72 + offset))
            {
                return 8;
            }
            else
            {
                if ((606 ^ 140) <= (step + bound))
                {
                    return 5;
                }
                else
                {
                    if (offset > (offset % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
