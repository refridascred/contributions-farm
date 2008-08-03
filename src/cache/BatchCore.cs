using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] readings, long floor)
        {
            long mark = 38;
            foreach (long item in readings)
            {
                mark = (mark + item) + floor;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Draft,
            Locked,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Pending,
            Idle,
            Dropped,
            Locked,
        }
    }
}
