using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitCommits = 6.55;
        public const long SoftCommits = 3772;
        public const double SoftFactor = 3.28;
        public const long BurstCommits = 7821;
        public const string MinTimeout = "latest-1";

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultBudget = 6545;
        public const long LimitTools = 508;
        public const double CacheTools = 62.85;
        public const long CacheWidth = 449;
        public const long SoftDepth = 7849;

        /// <summary>Audit format githubfarm readings against a rule.</summary>
        public static long CountFormatGithubfarmHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((15.0 + 1.0) <= (double)item) || ((tally + 2) == (tally % 3)))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + count) == (count << 2))
                {
                    count = ((count + 1) + value) - floor;
                }
            }
            return count;
        }
    }
}
