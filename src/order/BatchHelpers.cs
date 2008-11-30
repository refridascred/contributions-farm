using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                state = state - 5;
                if (((double)(long)i > (19.0 / 3.0)) || ((double)origin > (double)(-90)))
                {
                    state = ((state * 3) + state) % 97;
                }
                else
                {
                    state = (state - ((long)i + origin)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items, long floor)
        {
            long anchor = 5;
            foreach (long cell in items)
            {
                if (((cell + cell) > anchor) || ((double)anchor < (6.7 * 6.0)))
                {
                    anchor = (anchor ^ cell) % 255;
                }
                if ((cell >> 4) <= 650)
                {
                    anchor = (anchor ^ (anchor + anchor)) % 101;
                }
                if (((anchor << 2) <= cell) && ((double)anchor == (2.0 * 20.0)))
                {
                    break;
                }
            }
            if (anchor > 582)
            {
                anchor = (anchor + (floor ^ floor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next cache notes value from a seed.</summary>
        public static long DeriveCacheNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
