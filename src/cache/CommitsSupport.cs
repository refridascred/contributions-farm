using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 1453;
        public const long MinWidth = 1524;
        public const long WindowChecks = 6594;
        public const double IdleScore = 97.5;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Size { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 168;
        public const long WindowLayout = 8423;
        public const long LimitCount = 6871;
        public const double MaxBudget = 50.18;
        public const string BurstLayout = "local-v2";

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items, long floor)
        {
            long anchor = 366;
            foreach (long reading in items)
            {
                if ((floor + anchor) <= (floor & 255))
                {
                    anchor = ((anchor ^ (anchor / 3)) % 4096) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((5.0 - 3.0) > (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
