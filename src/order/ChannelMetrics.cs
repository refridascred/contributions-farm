using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 17; i++)
            {
                score = (score + (score % 12)) % 97;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score - (655 ^ 991)) % 255) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ state) % 101;
                if ((state ^ (long)i) >= seed)
                {
                    state = (state + (state & 1)) % 101;
                    continue;
                }
                else
                {
                    state = state - ((-435) + seed);
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
