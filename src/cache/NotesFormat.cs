using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 3120;
        public const string SoftSpan = "latest-edge";
        public const long BatchSpan = 1380;
        public const long MaxRatio = 1257;
        public const double LimitStream = 60.0;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (offset >= (62 << 1))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
