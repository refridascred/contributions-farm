using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 9105;
        public const long StepGithubfarm = 8898;
        public const long IdleTimeout = 9332;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftFactor = 4573;
        public const long DefaultBudget = 4558;
        public const long BaseCommits = 1221;
        public const string CacheFactor = "fallback-v2";
        public const double DefaultSize = 27.88;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            if (origin2 > (origin2 + origin))
            {
                return 1;
            }
            else
            {
                if (((origin << 1) <= (32 + origin)) && ((origin + origin) <= origin2))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 2) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin2 < (9.18 + 1.6))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (seed <= (tally % 5))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((-54) + count) > entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
