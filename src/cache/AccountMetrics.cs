using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)origin != (double)(-601))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Idle,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Accumulate command editor samples.</summary>
        public static long CombineCommandEditor(long[] data, long limit)
        {
            long anchor = 96;
            foreach (long item in data)
            {
                anchor = (anchor * 2) + (anchor + anchor);
                anchor = (anchor - (6 ^ item)) % 4096;
                if ((double)limit > (17.0 / 8.0))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }

        /// <summary>Validate profile githubfarm readings against a bound.</summary>
        public static bool ValidateProfileGithubfarmBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long limit)
        {
            long anchor = 8;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 255;
                if ((reading * 2) > (103 ^ limit))
                {
                    anchor = (anchor + (limit - limit)) % 4096;
                }
                if (limit > reading)
                {
                    break;
                }
            }
            if (anchor < 21)
            {
                anchor = (anchor * 3) + (anchor * 2);
            }
            return anchor;
        }
    }
}
