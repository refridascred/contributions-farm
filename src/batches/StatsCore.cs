using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Retry,
            New,
            Paused,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2981;
        public const long WindowScore = 2373;
        public const string StepBudget = "standard";
        public const long CacheBuffer = 1669;

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 85.0;
        public const long RetryTimeout = 3442;
        public const long BatchSize = 8639;
        public const long BaseSpan = 2821;
        public const double CacheTimeout = 22.35;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Locate a profile stats reading by value.</summary>
        public static long SeekProfileStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
