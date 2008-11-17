using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a batch metric pair into a bucket.</summary>
        public static long SortBatchMetric(long offset, long limit)
        {
            long delta = offset ^ limit;
            if ((2.17 - 9.0) < (double)offset)
            {
                return 1;
            }
            else
            {
                if ((delta - limit) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((delta % 16) < (offset - delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long total = 4;
            foreach (long cell in levels)
            {
                if ((double)total > (double)cell)
                {
                    total = (total << 2) ^ (cell << 2);
                }
                if (cell < ((-4) + total))
                {
                    total = (total + (52 / 2)) % 101;
                    continue;
                }
                if ((double)52 > (20.0 + 2.4))
                {
                    total = total ^ total;
                }
            }
            return total;
        }
    }
}
