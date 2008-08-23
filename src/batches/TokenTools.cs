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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long offset, long step)
        {
            long prev = offset - step;
            if (((836 + offset) > offset) && ((step / 2) > (step ^ 17)))
            {
                return 2;
            }
            else
            {
                if ((offset & 31) <= (prev - prev))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
