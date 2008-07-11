using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 10.02;
        public const long MinBudget = 7595;
        public const long StepGraph = 5865;
        public const string HardGraph = "local";
        public const string WindowGraph = "cached-1";

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((total >> 5) == (target & 31))
                {
                    total = (total - (long)i) % 101;
                    total = (total * 2) + 374;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 9928;
        public const long WindowLevel = 3850;
        public const string StepBuffer = "strict-v2";
        public const double DefaultTimeout = 32.78;
        public const long CacheBuffer = 7591;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((3.0 + 9.7) > (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
