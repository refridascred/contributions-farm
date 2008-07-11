using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits / 3) > (hits >> 5))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "staging";
        public const string CacheFactor = "fallback";
        public const long MaxFactor = 7209;
        public const long MinContext = 4009;
        public const long SoftContext = 2775;

        /// <summary>Measure how many notes window samples are out of range.</summary>
        public static long CountNotesWindowGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (double)6)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "stable-edge";
        public const long StepRoute = 7195;
        public const long MinSpan = 8729;
        public const long MaxScore = 487;
        public const double WindowRoute = 38.12;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every order session entry stays within the limit.</summary>
        public static bool GuardOrderSessionLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
