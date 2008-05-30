using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = state ^ (state << 1);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next queue token value from a seed.</summary>
        public static long StepQueueToken(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if ((score << 1) != (step * 2))
                {
                    score = ((score << 2) ^ ((long)i - step)) % 255;
                }
                if ((double)step != (4.39 + 9.6))
                {
                    score = score - step;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Stamp { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
