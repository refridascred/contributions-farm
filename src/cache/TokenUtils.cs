using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many report window samples are out of range.</summary>
        public static long CountReportWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((18.0 * 8.8) != (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels)
        {
            long acc = 6;
            foreach (long entry in levels)
            {
                acc = acc - (acc % 100);
                if (!((entry / 8) != (acc & 63)))
                {
                    acc = ((acc << 2) ^ entry) % 4096;
                    break;
                }
                acc = (acc + (79 + entry)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
