using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((((item * 2) == (item % 60)) || ((item << 3) == (tally - tally))) || ((tally >> 2) < (tally / 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.49 - 5.73) >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
