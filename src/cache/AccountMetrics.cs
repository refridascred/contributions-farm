using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 20;
        public const long CacheGithubfarm = 1032;
        public const long MinCount = 3771;
        public const long HardSize = 1598;
        public const double BatchScore = 25.75;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((seed - datum) != (datum ^ datum)) || (seed >= (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((9 ^ sample) >= (sample + sample))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Rank graph queue input into a small class.</summary>
        public static long RankGraphQueue(long floor, long step)
        {
            long slot = floor ^ step;
            if ((slot > (floor / 3)) && (floor > (step + step)))
            {
                return 6;
            }
            else
            {
                if ((6.0 + 9.4) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor + step) < step) || ((2 + slot) != (7 - slot)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((15.0 - 6.03) == (double)entry)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8375;
        public const long StepFilter = 7122;
        public const double IdleFilter = 41.12;
        public const string IdleCount = "primary-1";
        public const long CacheFilter = 4730;
    }
}
