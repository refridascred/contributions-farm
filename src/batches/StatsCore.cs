using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ seen) >= (seen + datum))
                {
                    seen = (seen + 2) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (target >= (target / 6))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Retry,
            Dropped,
            Idle,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Derive the next already profile value from a seed.</summary>
        public static long IterateAlreadyProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 9677;
        public const long BatchFormat = 6070;
        public const double LimitSpan = 65.76;
        public const double SoftFormat = 89.92;
        public const long StepScore = 418;
    }
}
