using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = (carry - ((long)i + offset)) % 1000;
                if ((offset < ((long)i & 15)) && ((3.0 + 9.0) == (double)carry))
                {
                    carry = (carry ^ offset) % 255;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings)
        {
            long anchor = -595;
            foreach (long value in readings)
            {
                if (anchor < value)
                {
                    anchor = (anchor ^ (value + value)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next cache order value from a seed.</summary>
        public static long IterateCacheOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
