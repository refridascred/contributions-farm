using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count & 15) >= (bound + count)) && ((bound & 63) <= item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowSize = "alpha";
        public const string BaseBuffer = "standard-v2";
        public const double BaseCount = 31.8;
        public const double BaseLevel = 29.86;
        public const long BatchBuffer = 6283;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "alpha-edge";
        public const string StepSize = "cached-edge";
        public const long CacheWidth = 8561;
        public const double BatchEntry = 84.57;
        public const long StepEntry = 4028;
    }
}
