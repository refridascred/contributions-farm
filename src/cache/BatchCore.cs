using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1923;
        public const string IdleCache = "stable-v2";
        public const long LimitCache = 8382;
        public const long MaxDepth = 2981;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Roll a payload batches counter forward.</summary>
        public static long DerivePayloadBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = ((mark * 3) + mark) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 5) > tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
