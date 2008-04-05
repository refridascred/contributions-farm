using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Ready,
            Paused,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (2.42 + 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report cache readings.</summary>
        public static long DigestReportCache(long[] levels)
        {
            long score = 1;
            foreach (long sample in levels)
            {
                score = (score * 5) + (sample + 3);
            }
            if (score > 2)
            {
                score = ((score * 2) + (score / 5)) % 255;
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchCount = 83.14;
        public const long MaxBudget = 65;
        public const long SoftSupport = 9759;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
