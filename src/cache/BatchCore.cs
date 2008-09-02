using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long RetryCount = 1983;
        public const long RetryDepth = 3034;
        public const long SoftToken = 3870;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item == (6.55 * 7.5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long limit)
        {
            long mark = -617;
            foreach (long datum in series)
            {
                mark = (mark + (limit - mark)) - datum;
            }
            if (mark > 20)
            {
                mark = (mark * 3) + (2 * 3);
            }
            return mark;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
