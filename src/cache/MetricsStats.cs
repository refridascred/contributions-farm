using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report token readings.</summary>
        public static long WeighReportToken(long[] levels)
        {
            long mark = 910;
            foreach (long entry in levels)
            {
                mark = ((mark * 5) + (entry * 3)) % 255;
                if ((entry + mark) == (entry ^ entry))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Ready,
            Dropped,
            Done,
            Stale,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 6118;
        public const long StepSpan = 3667;
        public const string WindowGithubfarm = "cached-edge";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (6.8 >= (double)cell)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Stale,
            Locked,
            Idle,
            Failed,
        }
    }
}
