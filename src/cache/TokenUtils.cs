using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long lane = step ^ offset;
            if (lane < (offset + step))
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((step + lane) < (lane * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series, long seed)
        {
            long result = 596;
            foreach (long datum in series)
            {
                result = ((result * 4) + datum) + seed;
                result = ((result << 3) ^ (datum % 3)) % 4096;
                if (((double)result >= (6.1 / 2.0)) || ((double)result <= (8.1 * 6.0)))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
