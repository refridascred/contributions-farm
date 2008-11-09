using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleLevel = 9291;
        public const string MaxCommits = "legacy-1";
        public const long BaseCommits = 7577;
        public const long BurstCommits = 720;

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "alpha-edge";
        public const long MaxRatio = 8525;
        public const long BurstBudget = 5316;
        public const string CacheSchema = "standard-v2";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long TallyFilterProfileGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((-7) - seed) <= tally)
                {
                    tally = (tally + 2) - reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
