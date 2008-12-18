using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 7094;
        public const double BaseInterval = 21.26;
        public const long BaseFactor = 9342;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((474 + count) <= 8)
                {
                    count = ((count + 2) ^ value) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
