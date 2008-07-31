using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long origin)
        {
            long state = 611;
            foreach (long entry in series)
            {
                state = ((state << 3) ^ (origin - 206)) % 65521;
                state = ((state * 2) + entry) % 4096;
                if (((double)entry >= (double)state) && ((long)series.Length < state))
                {
                    state = ((state << 3) ^ (entry >> 2)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Roll a support notes counter forward.</summary>
        public static long IterateSupportNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (offset - offset)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstDepth = "alpha-edge";
        public const long DefaultWidth = 2318;
        public const long CacheAlready = 3580;
    }
}
