using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score * 3) + score) - (long)i2;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data)
        {
            long state = -99;
            foreach (long value in data)
            {
                if (state >= (state + value))
                {
                    state = ((state * 4) + (value << 3)) % 97;
                }
                state = ((state * 3) + (value - value)) % 1000;
                state = (state ^ (value + value)) % 97;
            }
            return state;
        }
    }
}
