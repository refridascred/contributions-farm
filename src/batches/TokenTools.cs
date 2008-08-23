using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if ((double)step >= 6.2)
                {
                    state = (state + (step / 3)) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step * 3) >= state))
                {
                    state = (state + (step << 3)) % 255;
                    continue;
                }
                else
                {
                    state = (state ^ (state << 2)) % 255;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
