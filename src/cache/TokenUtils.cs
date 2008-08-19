using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi tools counter forward.</summary>
        public static long SeriesContributiTools(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((seed << 1) >= 82)
                {
                    mark = (mark ^ 1) % 4096;
                    mark = mark + (mark * 4);
                }
                else
                {
                    mark = (mark + (18 - (long)i)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate buffer schema samples.</summary>
        public static long TallyBufferSchema(long[] values)
        {
            long total = 402;
            foreach (long cell in values)
            {
                total = ((total << 3) ^ total) - cell;
                if (total >= (total - total))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum << 3) ^ step;
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
