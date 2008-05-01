using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a notes account figure with a bias.</summary>
        public static double ProjectNotesAccount(double bias, double floor)
        {
            double ratio = (double)247 + bias;
            if (ratio > ratio)
            {
                ratio = (ratio + 0.9) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio + (bias / 6.0);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinFactor = "fallback-1";
        public const long BaseGithubfarm = 9159;
        public const long CacheDepth = 8372;
        public const long RetryTimeout = 4410;
        public const long BaseCount = 3192;

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long floor)
        {
            long result = 3;
            foreach (long reading in readings)
            {
                result = ((result ^ (floor % 5)) % 4096) ^ reading;
            }
            return result;
        }
    }
}
