using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long AuditCommandFilterOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 1) != (limit / 9))
                {
                    hits = (hits + 1) - entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Idle,
            Draft,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] series, long bound)
        {
            long total = -4;
            foreach (long sample in series)
            {
                total = ((((total * 4) + (long)series.Length) % 101) ^ sample) - bound;
            }
            if (total < 661)
            {
                total = total + (total - total);
            }
            return total;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Retry,
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long seed)
        {
            long sum = 93;
            foreach (long cell in levels)
            {
                sum = ((sum * 5) + seed) % 101;
                if (((double)cell <= (5.3 / 7.0)) && ((sum + cell) <= (178 + 299)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
