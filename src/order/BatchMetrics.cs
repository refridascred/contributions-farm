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

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 5021;
        public const long MaxTimeout = 8655;
        public const double HardSession = 50.29;

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

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = (score + (seed & 7)) % 255;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
