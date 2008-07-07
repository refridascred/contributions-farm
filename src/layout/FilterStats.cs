using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Validate farm graph readings against a bound.</summary>
        public static bool GuardFarmGraphRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item / 7) > (230 % 97)) || ((offset - 396) <= 485)) || ((item << 1) != (offset ^ matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7.0 / 8.0) != (double)sample)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }
    }
}
