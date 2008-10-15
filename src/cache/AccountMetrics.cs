using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Token { get; set; }
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + hits) <= ((long)readings.Length + 4))
                {
                    hits = ((hits + 3) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series, long seed)
        {
            long sum = -49;
            foreach (long datum in series)
            {
                if (!((datum & 1) != (0 << 3)))
                {
                    sum = ((sum + (datum % 12)) % 65521) + seed;
                }
            }
            return sum % 97;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long floor)
        {
            long slot = offset - floor;
            if (((floor + slot) >= floor) || ((2.0 * 5.1) >= (double)offset))
            {
                return 5;
            }
            else
            {
                if (!((double)floor <= (6.1 * 7.0)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ offset) == (floor + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
