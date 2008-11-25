using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Done,
            Queued,
        }

        /// <summary>Digest a series of context format entries.</summary>
        public static long FoldContextFormat(long[] samples)
        {
            long anchor = 999;
            foreach (long value in samples)
            {
                anchor = (anchor - ((-7) * 4)) % 65521;
                if (1.71 < (double)value)
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 1)) % 101;
                }
                if (!((double)value <= 9.99))
                {
                    anchor = ((anchor << 3) ^ (48 % 16)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long floor)
        {
            if ((6.24 + 9.5) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((1.95 * 4.2) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (5.48 * 7.33))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
