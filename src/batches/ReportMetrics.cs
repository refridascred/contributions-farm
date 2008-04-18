using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Active,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Count queue checks pairs that satisfy a relation.</summary>
        public static long CompareQueueChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                if ((2.7 - 2.0) != (double)anchor)
                {
                    anchor = ((anchor * 2) + (anchor - (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
