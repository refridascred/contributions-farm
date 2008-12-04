using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long AuditCommitsCounterOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((0.65 / 3.0) > (double)datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            New,
            Dropped,
            Paused,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool CheckCommitsEditorRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
