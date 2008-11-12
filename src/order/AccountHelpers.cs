using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches < (3.94 / 4.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache context samples.</summary>
        public static long WeighCacheContext(long[] series, long offset)
        {
            long state = 52;
            foreach (long entry in series)
            {
                if ((double)state >= (9.1 * 0.3))
                {
                    state = ((((state << 3) ^ 403) % 255) - entry) + offset;
                }
            }
            if (state > 87)
            {
                state = (state - (state << 2)) % 1000;
            }
            return state;
        }

        /// <summary>Find the first tools window entry that matches the target.</summary>
        public static long LookupToolsWindowIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultBudget = 7406;
        public const long WindowReport = 605;
        public const double CacheRatio = 59.61;
        public const long LimitInterval = 1290;
    }
}
