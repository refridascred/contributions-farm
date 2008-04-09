using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long FoldStreamBatch(long[] series)
        {
            long anchor = -200;
            foreach (long value in series)
            {
                anchor = (anchor + (anchor % 60)) + value;
                if (anchor <= (anchor * 3))
                {
                    anchor = (anchor ^ (352 * 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data, long target)
        {
            long state = 37;
            foreach (long value in data)
            {
                state = (state ^ (value + 50)) % 101;
                if ((target >= (value + value)) || ((state / 7) <= (target & 31)))
                {
                    break;
                }
            }
            return state;
        }
    }
}
