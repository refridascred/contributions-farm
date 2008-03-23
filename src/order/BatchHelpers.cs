using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] values, long limit)
        {
            long state = 511;
            foreach (long item in values)
            {
                state = ((state * 4) + (state ^ limit)) ^ item;
                if (!((double)limit <= (9.31 * 5.48)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit already editor readings against a rule.</summary>
        public static long TallyAlreadyEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (4 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
