using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 127) > (92 + datum))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long AuditCacheMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell / 8) >= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
