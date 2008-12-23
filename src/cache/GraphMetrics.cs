using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the stats graph entries that pass the check.</summary>
        public static long AuditStatsGraphGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((1.6 * 7.7) != (double)origin)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((step + item) <= (step + 46))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Dropped,
            Draft,
            Active,
            Done,
        }

        /// <summary>Check that every filter payload entry stays within the limit.</summary>
        public static bool VerifyFilterPayloadRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data)
        {
            long total = 258;
            foreach (long entry in data)
            {
                if ((total ^ entry) < (total & 31))
                {
                    total = (total << 2) ^ (entry + entry);
                }
            }
            if (total > 3)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total;
        }
    }
}
