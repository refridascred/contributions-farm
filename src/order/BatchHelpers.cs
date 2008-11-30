using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
