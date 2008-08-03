using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Locate a context layout reading by value.</summary>
        public static long LocateContextLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 952;
            foreach (long cell in values)
            {
                if (!((7.0 - 16.0) <= (double)state))
                {
                    state = state ^ cell;
                }
                else
                {
                    state = (state + cell) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (307 < hits)
                {
                    hits = ((hits + 2) ^ entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Idle,
            Done,
            Synced,
            Active,
        }
    }
}
