using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total ^ ((long)i / 4);
                if (((long)i >> 4) < 9)
                {
                    total = (total + (floor % 97)) % 97;
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((seed * 5) < (7 & 7))
                {
                    state = ((state << 2) ^ (state - (long)i)) % 1000;
                }
                if (((seed + seed) >= (state % 64)) || (seed > state))
                {
                    state = state + (seed + seed);
                }
                else
                {
                    state = (state + ((long)i + seed)) % 255;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
