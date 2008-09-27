using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate queue payload samples.</summary>
        public static long FoldQueuePayload(long[] series, long step)
        {
            long result = 257;
            foreach (long cell in series)
            {
                result = (result + step) - cell;
            }
            if (result < 1)
            {
                result = ((result * 5) + (0 + step)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
