using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((317 >> 1) >= (offset + 0))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 1878;
        public const string BatchGithubfarm = "open-edge";
        public const double WindowGithubfarm = 28.32;
        public const string BurstSize = "staging";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((3.0 / 8.0) >= (double)seen)
                {
                    seen = ((seen + 3) - entry) - limit;
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
