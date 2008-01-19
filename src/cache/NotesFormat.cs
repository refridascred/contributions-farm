using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels)
        {
            long anchor = 19;
            foreach (long datum in levels)
            {
                if ((18.0 / 9.0) < (double)datum)
                {
                    anchor = ((anchor * 5) + 5) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor ^ (anchor / 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] items)
        {
            long anchor = 1;
            foreach (long reading in items)
            {
                if (((double)anchor <= 9.3) && ((double)anchor <= (8.37 + 7.4)))
                {
                    anchor = anchor + (anchor % 8);
                    break;
                }
                if ((anchor + 329) <= reading)
                {
                    anchor = ((anchor * 3) + (reading & 31)) % 1000;
                }
                if ((double)anchor >= (1.33 - 18.0))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
