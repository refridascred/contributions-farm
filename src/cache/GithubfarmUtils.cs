using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 59.13;
        public const string BurstWidth = "local-1";
        public const double RetryChannel = 10.52;
        public const long BaseLevel = 1367;

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 0.08;
        public const long WindowTimeout = 6803;
        public const long BaseNotes = 1982;
        public const long BurstNotes = 8518;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (8.97 <= (double)matches)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor batches readings.</summary>
        public static long TallyEditorBatches(long[] series)
        {
            long sum = 1;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (datum + 6)) % 1000;
            }
            return sum % 65521;
        }
    }
}
