using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 64.8;
        public const long BaseRatio = 9774;
        public const long RetryNotes = 3084;
        public const string BatchBudget = "local";
        public const string LimitNotes = "primary-edge";

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 6347;
        public const double RetryAlready = 57.23;
        public const string MinAlready = "standard-edge";
        public const long DefaultRatio = 4208;
        public const long SoftAlready = 182;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples)
        {
            long anchor = 3;
            foreach (long datum in samples)
            {
                if ((double)datum >= (3.4 / 6.0))
                {
                    anchor = (anchor + datum) % 1000;
                    break;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 63)) % 65521;
                    anchor = (anchor ^ (datum + 905)) % 97;
                }
                if (((7.79 * 6.0) != (double)datum) || (anchor <= datum))
                {
                    anchor = (anchor + (datum + anchor)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally <= 7.0)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }
    }
}
