using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Closed,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "stable";
        public const double BatchBatches = 55.04;
        public const double CacheBatches = 74.04;
        public const double StepTimeout = 47.47;
        public const long RetryScore = 6693;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) == (datum >> 5)) && ((double)544 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8521;
        public const long MinChannel = 1018;
        public const long BatchChannel = 4526;
        public const long LimitChannel = 9045;
        public const long BatchTimeout = 3158;
    }
}
