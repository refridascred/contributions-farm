using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster format value from a seed.</summary>
        public static long IterateClusterFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                if (((bound - bound) != ((long)i >> 1)) && ((20 + bound) <= 4))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state - (bound * 3)) % 1000;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long floor, long origin)
        {
            long step = floor ^ origin;
            if ((origin >= (33 & 3)) || (step >= (floor - floor)))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= (9.9 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if (((step + origin) < (step % 3)) && (((-85) << 2) < step))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor / 7) >= floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Locked,
            New,
            Ready,
        }
    }
}
