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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long offset2)
        {
            long bound = offset - offset2;
            if ((offset2 + offset2) <= (bound ^ 306))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) < (offset % 60))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
