using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Paused,
            New,
            Retry,
            Draft,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 58.58;
        public const long BaseCount = 206;
        public const long LimitSize = 1783;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 498;
        public const double LimitContributi = 75.29;
        public const long IdleDepth = 5663;
        public const long MaxContributi = 8848;
        public const long BatchSpan = 4665;
    }
}
