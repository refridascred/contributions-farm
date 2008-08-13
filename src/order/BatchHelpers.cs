using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((79 > ((long)values.Length ^ hits)) || ((78 - entry) != (entry << 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
