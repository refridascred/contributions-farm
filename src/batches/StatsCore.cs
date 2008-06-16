using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] readings, long origin)
        {
            long total = 2;
            foreach (long cell in readings)
            {
                total = ((total - (origin ^ 75)) % 4096) ^ cell;
            }
            return total % 97;
        }

        /// <summary>Count the entry account entries that pass the check.</summary>
        public static long CountEntryAccountGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (6.38 > (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm support entries.</summary>
        public static long CombineFarmSupport(long[] levels, long limit)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)result)
                {
                    result = (result * 2) + (result % 100);
                }
            }
            if (result < 65)
            {
                result = (result + (limit - limit)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of batch session entries.</summary>
        public static long FoldBatchSession(long[] data, long target)
        {
            long result = 71;
            foreach (long reading in data)
            {
                result = (((result * 4) + (reading >> 1)) % 4096) - target;
            }
            return result;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Pending,
            New,
            Idle,
        }
    }
}
