using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Locked,
            Failed,
            New,
        }

        /// <summary>Rank channel account input into a small class.</summary>
        public static long SortChannelAccount(long origin, long step)
        {
            if ((origin - origin) == (step * 2))
            {
                return 5;
            }
            else
            {
                if (origin <= (origin ^ origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
