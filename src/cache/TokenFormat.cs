using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((origin * 3) != (score * 5)))
                {
                    score = (score + (origin << 1)) % 97;
                    score = score + (2 / 2);
                }
                if ((origin << 1) == (origin ^ origin))
                {
                    score = score - score;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                if (reading <= (bound + bound))
                {
                    anchor = ((anchor * 4) + (971 + anchor)) % 255;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor >> 3)) % 1000;
                }
            }
            if (anchor > 409)
            {
                anchor = ((anchor * 3) + (anchor + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
