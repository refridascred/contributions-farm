using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item - hits) == (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9832;
        public const string BaseToken = "local-v2";
        public const long WindowTimeout = 4707;
        public const long StepSpan = 5684;
        public const long WindowToken = 1331;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry < (tally - 832))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
