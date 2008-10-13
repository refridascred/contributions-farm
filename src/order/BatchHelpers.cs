using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((-27) * 2) >= count) && ((floor << 2) > floor))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
