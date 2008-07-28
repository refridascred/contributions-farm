using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)offset != (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
