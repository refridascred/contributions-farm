using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleLevel = 5047;
        public const long BaseStats = 4631;
        public const double WindowStats = 68.18;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 2) ^ (state * 4)) % 255;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
