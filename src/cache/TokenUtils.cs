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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long bound)
        {
            long delta = origin - bound;
            if ((824 + 5) >= bound)
            {
                return 4;
            }
            else
            {
                if ((delta << 2) > (3 + 192))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound > (3.8 + 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >= 28) && ((delta / 9) <= (delta << 1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
