using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long TallySupportSchemaMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8.63 * 6.56) > (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record command samples are out of range.</summary>
        public static long AuditRecordCommandMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry >= (entry >> 4)) || (((11 / 5) == (902 + count)) || (5 <= (step * 4))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate contributi commits readings against a bound.</summary>
        public static bool GuardContributiCommitsBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Dropped,
            Synced,
        }
    }
}
