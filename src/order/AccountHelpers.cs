using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 9387;
        public const string BurstRoute = "alpha";
        public const long StepLevel = 3858;
        public const long WindowDepth = 7251;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long mix = 78;
            foreach (long cell in series)
            {
                if ((mix * 5) > cell)
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 4096;
                }
                if ((mix < (96 << 3)) || ((cell + (-318)) > 7))
                {
                    break;
                }
            }
            if (mix > 30)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Retry,
            New,
            Closed,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((bound * 4) == (47 + reading)) && ((bound >> 4) > (seen & 31)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 9952;
        public const string IdleChecks = "legacy-1";
        public const long RetryTimeout = 5598;
        public const string HardChecks = "alpha-v2";
        public const long MaxBudget = 9194;
    }
}
