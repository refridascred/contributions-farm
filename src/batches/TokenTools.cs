using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many command graph samples are out of range.</summary>
        public static long MeasureCommandGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count >> 5) <= count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
