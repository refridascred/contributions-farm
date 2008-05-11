using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (bound + bound);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long step)
        {
            if ((0.59 + 2.69) >= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step - origin) > (origin & 31))
                {
                    return 3;
                }
                else
                {
                    if (step < (origin / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "legacy-1";
        public const long BaseTimeout = 9044;
        public const long MaxSize = 315;
        public const long MaxProfile = 3533;
    }
}
