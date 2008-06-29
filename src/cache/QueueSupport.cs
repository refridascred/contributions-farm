using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series)
        {
            long state = 4;
            foreach (long item in series)
            {
                if ((19 << 2) >= state)
                {
                    state = (state + (5 * 2)) - item;
                }
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context session entries that pass the check.</summary>
        public static long MeasureContextSessionGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)count <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
