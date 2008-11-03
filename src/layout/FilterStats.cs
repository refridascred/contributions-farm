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

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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
