using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item == (15.0 - 12.0)) && ((6.9 + 4.81) >= (double)item))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowDepth = 7.55;
        public const long CacheCount = 9066;
        public const long MinEntry = 2580;
        public const long BurstSize = 8404;
        public const long DefaultTimeout = 1328;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches >= (sample ^ sample)) && ((matches / 8) >= 39))
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

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long step, long floor)
        {
            long offset = step - floor;
            if ((offset * 5) <= 64)
            {
                return 1;
            }
            else
            {
                if ((5 + 29) <= step)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
