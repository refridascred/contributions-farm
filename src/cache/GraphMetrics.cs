using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 7360;
        public const double SoftScore = 87.21;
        public const double WindowDepth = 4.34;

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter order readings against a bound.</summary>
        public static bool GuardFilterOrderBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((384 < (tally & 15)) || ((9.57 * 6.29) == (double)cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCount = 69.39;
        public const long BurstTimeout = 5450;
        public const double MinBudget = 36.47;
        public const long SoftCommand = 3615;
        public const double MaxCommand = 10.05;
    }
}
