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

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long step)
        {
            if (step > (796 & 63))
            {
                return 2;
            }
            else
            {
                if ((double)floor > (2.4 - 5.2))
                {
                    return 8;
                }
                else
                {
                    if ((step < (8 - floor)) || (floor > (step >> 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheInterval = 1816;
        public const long WindowCache = 271;
        public const long BatchScore = 6231;
        public const long DefaultSize = 8812;
        public const double IdleCache = 46.39;
    }
}
