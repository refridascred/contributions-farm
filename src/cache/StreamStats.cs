using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((5.5 - 9.2) >= (double)reading)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryBudget = 95.01;
        public const long DefaultBudget = 4342;
        public const string LimitInterval = "stable-1";
        public const double MaxChecks = 6.23;
        public const string BaseBudget = "cached-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "open-edge";
        public const long MaxChannel = 48;
        public const long BaseChannel = 1571;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 3) == (count - reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
