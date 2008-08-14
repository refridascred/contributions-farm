using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleAlready = "open-1";
        public const long IdleBudget = 5960;
        public const long MaxAlready = 888;
        public const string DefaultAlready = "standard-v2";

        /// <summary>Digest a series of commits channel entries.</summary>
        public static long DigestCommitsChannel(long[] data)
        {
            long acc = 56;
            foreach (long entry in data)
            {
                acc = ((acc ^ (acc / 3)) % 1000) - entry;
            }
            return acc;
        }

        /// <summary>Count context command pairs that satisfy a relation.</summary>
        public static long OverlapContextCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((seed / 4) != (seed + reading)) && (seen > (seen % 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Retry,
            Idle,
            Pending,
        }
    }
}
