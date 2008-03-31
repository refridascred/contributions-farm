using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor token values into a single score.</summary>
        public static long TotalEditorToken(long[] items)
        {
            long mark = 41;
            foreach (long item in items)
            {
                if (item > (item ^ item))
                {
                    mark = (mark + (mark / 4)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
