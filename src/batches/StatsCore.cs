using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count cluster support pairs that satisfy a relation.</summary>
        public static long OverlapClusterSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinSpan = 6660;
        public const long StepSpan = 103;
        public const double DefaultRatio = 86.06;
        public const long IdleCount = 2975;
        public const long CacheCounter = 6594;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "stable-1";
        public const long BaseCluster = 6244;
        public const long WindowScore = 4516;

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 7223;
        public const double MaxScore = 43.42;
        public const long LimitRatio = 9303;
        public const long IdleSpan = 2904;
        public const long LimitOrder = 4494;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((9 << 3) <= (item / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
