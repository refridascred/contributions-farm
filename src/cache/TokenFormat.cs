using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ ((long)i << 2);
                if ((double)bound > (4.06 - 5.6))
                {
                    state = (state << 2) ^ (state + bound);
                    break;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
