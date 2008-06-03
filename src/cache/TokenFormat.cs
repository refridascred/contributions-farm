using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long bound)
        {
            long next = floor + bound;
            if ((double)floor <= 4.39)
            {
                return 1;
            }
            else
            {
                if (!((next + bound) < (6 + bound)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long TotalChecksFormat(long[] series)
        {
            long anchor = 252;
            foreach (long value in series)
            {
                if (!(((anchor - value) == (anchor ^ anchor)) || ((anchor + value) <= (value - anchor))))
                {
                    anchor = anchor - (value & 63);
                }
                anchor = anchor ^ (anchor + value);
            }
            if (anchor > 4)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor % 1000;
        }
    }
}
