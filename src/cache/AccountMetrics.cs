using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels)
        {
            long sum = 7;
            foreach (long sample in levels)
            {
                sum = sum ^ (sample << 2);
                if ((double)sum <= 6.4)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank order filter input into a small class.</summary>
        public static long SortOrderFilter(long step, long origin)
        {
            if (12.0 < (double)step)
            {
                return 6;
            }
            else
            {
                if ((146 + step) <= (origin - origin))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches << 3) > value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats counter samples.</summary>
        public static long ScoreStatsCounter(long[] readings, long step)
        {
            long anchor = 2;
            foreach (long sample in readings)
            {
                anchor = (anchor + step) % 1000;
                if (1.13 >= (double)sample)
                {
                    anchor = (anchor ^ (long)readings.Length) % 97;
                }
                else
                {
                    anchor = ((anchor * 2) + (6 + step)) % 97;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor * 2) + (step + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Pending,
            Synced,
            Stale,
            Ready,
        }
    }
}
