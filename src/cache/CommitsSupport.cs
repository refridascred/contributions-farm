using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftInterval = 2678;
        public const double SoftProfile = 98.85;
        public const long LimitSpan = 2695;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) == (seen - target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchInterval = 4719;
        public const long DefaultBudget = 5863;
        public const string BaseFilter = "open-v2";
        public const long WindowSpan = 8614;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + 6) > (hits - 55))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
