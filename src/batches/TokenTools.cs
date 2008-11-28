using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long state = floor;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ (state % 60)) % 4096;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count channel farm pairs that satisfy a relation.</summary>
        public static long MatchChannelFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Synced,
            Pending,
            Ready,
            Active,
        }
    }
}
