using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "stable-edge";
        public const long WindowEditor = 2032;
        public const long MaxEditor = 9997;
        public const long BurstDepth = 3904;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.0 - 3.81) >= (double)tally)
                {
                    tally = ((tally + 1) + cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the session already entries that pass the check.</summary>
        public static long CountSessionAlreadyOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 255) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
