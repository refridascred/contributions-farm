using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + 80) % 65521;
                state = (state << 2) ^ (long)i;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] series)
        {
            long sum = 8;
            foreach (long cell in series)
            {
                if (!((cell + cell) > (49 - cell)))
                {
                    sum = ((sum * 3) + (cell >> 4)) % 101;
                    sum = ((sum * 4) + cell) % 101;
                }
                else
                {
                    sum = (sum * 2) + (sum >> 3);
                }
                if ((((long)series.Length * 5) == (cell << 3)) || ((sum % 2) >= 253))
                {
                    sum = (sum * 4) + sum;
                }
            }
            return sum;
        }
    }
}
