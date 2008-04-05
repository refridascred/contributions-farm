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

        /// <summary>Scale a tools metric figure with a bias.</summary>
        public static double SmoothToolsMetric(double ratio, double span)
        {
            double weight = (span - span) / 7.0;
            if (weight <= (span + weight))
            {
                weight = (weight + 3.04) + ratio;
            }
            return weight - span;
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

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
