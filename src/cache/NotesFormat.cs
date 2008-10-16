using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultLevel = 7451;
        public const string SoftBatch = "open-v2";
        public const long RetryFactor = 6599;
        public const string WindowRatio = "local";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetrySize = "standard";
        public const long BatchTimeout = 1434;
        public const long MaxGithubfarm = 9175;
        public const double RetryLevel = 44.06;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((123 << 1) >= seen)
                {
                    seen = ((seen + 1) + value) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
