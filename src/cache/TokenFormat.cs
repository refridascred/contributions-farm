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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] values)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = (result << 3) ^ (item / 9);
            }
            if (result < 66)
            {
                result = (result * 3) + (result * 5);
            }
            return result % 1000;
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
