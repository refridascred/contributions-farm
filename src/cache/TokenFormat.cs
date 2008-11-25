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

        /// <summary>Roll a cache counter forward.</summary>
        public static long IterateCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)origin == (1.4 + 20.0))
                {
                    result = ((result << 3) ^ (21 % 12)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
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
