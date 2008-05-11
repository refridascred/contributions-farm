using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit route stream readings against a rule.</summary>
        public static long MeasureRouteStreamOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) < (sample - 72))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Synced,
            Dropped,
            Stale,
            Idle,
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
