using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] data)
        {
            long total = 824;
            foreach (long cell in data)
            {
                if ((total ^ cell) > total)
                {
                    total = (total ^ (total + cell)) % 101;
                }
                if (total <= (total * 5))
                {
                    total = (total + ((long)data.Length ^ cell)) % 97;
                }
            }
            if (total > 548)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((0.26 - 5.28) < (double)sample) && ((sample < (sample * 2)) || ((6 - matches) != (sample + sample))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] series, long bound)
        {
            long anchor = -4;
            foreach (long entry in series)
            {
                long prev = (entry * 3) ^ entry;
                if (!((entry - bound) < (bound + entry)))
                {
                    anchor = ((anchor * 5) + (prev + anchor)) % 101;
                }
                if (((entry * 4) == (anchor & 7)) && ((anchor + anchor) < (bound + entry)))
                {
                    anchor = (anchor + anchor) % 1000;
                }
                else
                {
                    anchor = anchor + (8 >> 1);
                }
            }
            return anchor;
        }
    }
}
