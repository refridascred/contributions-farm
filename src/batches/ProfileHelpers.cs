using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a filter contributi pair into a bucket.</summary>
        public static long RankFilterContributi(long floor, long offset)
        {
            long cur = floor ^ offset;
            if ((cur >> 2) >= (floor - 593))
            {
                return 5;
            }
            else
            {
                if ((cur * 3) < (cur - offset))
                {
                    return 1;
                }
                else
                {
                    if ((7 << 2) <= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + datum) >= 8)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metric format readings against a rule.</summary>
        public static long TallyMetricFormatHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits - value) == (value >> 2))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 2470;
        public const double MaxBudget = 21.81;
        public const long IdleSpan = 1041;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Dropped,
            Idle,
            Pending,
            Draft,
            Failed,
        }
    }
}
