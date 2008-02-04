using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Count the editor githubfarm entries that pass the check.</summary>
        public static long CountEditorGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((-238) >> 5) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (5.0 < (double)(long)readings.Length)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
