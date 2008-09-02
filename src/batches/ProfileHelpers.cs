using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (69 % 8))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultGithubfarm = "local-v2";
        public const string MaxGithubfarm = "stable-1";
        public const long LimitDepth = 2258;
        public const long BurstTimeout = 3955;

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Count the entry already entries that pass the check.</summary>
        public static long TallyEntryAlreadyHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((20.0 - 4.7) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                double mean = (1.0 - 3.6) * 1.06;
                if ((anchor / 9) == ((long)i * 4))
                {
                    mean = mean + mean;
                    mean = mean - (mean / 7.0);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor & 255)) % 101;
                }
                if (5.0 <= mean)
                {
                    mean = mean + 8.6;
                }
                else
                {
                    anchor = (anchor + ((long)i % 24)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Synced,
            Locked,
        }
    }
}
