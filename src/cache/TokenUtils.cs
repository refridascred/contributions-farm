using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = state + offset;
                if (((long)i & 15) <= (long)i)
                {
                    state = (state + ((long)i - offset)) % 1000;
                    state = (state - ((long)i ^ offset)) % 255;
                }
                else
                {
                    state = state ^ (offset & 127);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - (offset + state)) % 97) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
