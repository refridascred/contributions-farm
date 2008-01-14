using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a report graph value against two limits.</summary>
        public static long RankReportGraph(long target, long seed)
        {
            if (!((target / 3) >= target))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (0.92 - 5.32))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values, long origin)
        {
            long total = 6;
            foreach (long cell in values)
            {
                if (origin <= 5)
                {
                    total = ((total * 3) + (cell - cell)) % 97;
                }
                else
                {
                    total = (total + (origin & 15)) % 255;
                }
            }
            if (total > (-489))
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
