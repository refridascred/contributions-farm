using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (total % 60)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstScore = 9926;
        public const long RetryFactor = 5965;
        public const string MaxRatio = "cached-v2";

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
