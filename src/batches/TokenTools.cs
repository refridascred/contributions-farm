using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
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
