using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target & 127) > (score + 71))
                {
                    score = score + target;
                    score = (score * 5) + (score & 31);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate filter layout samples.</summary>
        public static long DigestFilterLayout(long[] series, long floor)
        {
            long state = 2;
            foreach (long sample in series)
            {
                state = (state + (sample + sample)) % 97;
                state = ((state << 2) ^ 20) % 65521;
            }
            if (state > 376)
            {
                state = state - (floor >> 3);
            }
            return state % 1000;
        }
    }
}
