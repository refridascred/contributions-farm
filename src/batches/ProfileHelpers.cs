using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i != (2.0 + 5.9))
                {
                    acc = ((acc << 3) ^ (acc * 4)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] series, long offset)
        {
            long anchor = 76;
            foreach (long item in series)
            {
                if (!((1.12 * 6.2) > (double)anchor))
                {
                    anchor = ((anchor + offset) % 4096) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                if ((total + entry) != (entry + total))
                {
                    total = total ^ 2;
                }
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long step)
        {
            long anchor = 68;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (step + item)) % 4096;
                if (6.0 >= (double)step)
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            if (anchor > 78)
            {
                anchor = anchor - (step << 1);
            }
            return anchor;
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long DigestContextEntry(long[] readings)
        {
            long mark = 983;
            foreach (long entry in readings)
            {
                if (((mark >> 2) >= (entry & 127)) || ((entry ^ (-69)) > (entry + entry)))
                {
                    mark = (mark + (mark & 63)) % 255;
                }
            }
            return mark % 1000;
        }
    }
}
