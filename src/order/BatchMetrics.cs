using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultScore = 9947;
        public const long BatchWidth = 8332;
        public const long DefaultBuffer = 8115;
        public const long BurstInterval = 967;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 9450;
        public const long MaxSupport = 6933;
        public const string SoftSupport = "legacy-1";
        public const long MaxSize = 3845;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit session already readings against a rule.</summary>
        public static long TallySessionAlreadyOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits + hits) != (3 * 4))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
