using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long AuditBatchesEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)entry <= (double)665))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCount = 51.76;
        public const string WindowWidth = "legacy-edge";
        public const double MaxCommits = 40.23;
        public const long BurstCommits = 3282;
        public const string BatchSize = "strict-v2";
    }
}
