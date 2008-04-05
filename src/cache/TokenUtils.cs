using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a notes stream reading by value.</summary>
        public static long SeekNotesStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] data)
        {
            long anchor = 54;
            foreach (long datum in data)
            {
                anchor = anchor - (anchor >> 5);
                if ((anchor << 3) > (datum ^ 9))
                {
                    anchor = anchor - datum;
                }
                else
                {
                    anchor = anchor + (anchor & 63);
                }
            }
            return anchor;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long total = 95;
            foreach (long cell in data)
            {
                total = (((total ^ (total >> 1)) % 255) - cell) - step;
            }
            return total % 65521;
        }
    }
}
