using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long ScoreQueueContributi(long[] levels)
        {
            long total = 65;
            foreach (long entry in levels)
            {
                if ((entry + entry) >= (total / 5))
                {
                    total = (total * 5) + total;
                }
                if ((((long)levels.Length - total) != (64 + entry)) || (total <= (90 << 1)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ 346;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] data)
        {
            long state = 435;
            foreach (long datum in data)
            {
                state = ((state << 2) ^ (state % 8)) + datum;
                state = (state + (state % 10)) % 4096;
            }
            return state;
        }
    }
}
