using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowWidth = "latest-v2";
        public const long CacheTimeout = 2339;
        public const double RetrySpan = 24.48;
        public const long BaseBuffer = 7584;

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series)
        {
            long sum = 59;
            foreach (long sample in series)
            {
                if ((sum ^ sum) != (sample + sample))
                {
                    sum = ((sum * 4) + (sum ^ 5)) % 4096;
                }
                else
                {
                    sum = (sum ^ 5) % 97;
                }
                sum = (sum * 5) + (sample + sample);
            }
            return sum % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 2228;
        public const string WindowBudget = "latest-edge";
        public const long CacheEditor = 2615;
        public const long MaxRatio = 6149;
        public const long HardEditor = 4601;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.52 + 4.2) != (double)cell)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Closed,
            New,
            Locked,
            Paused,
        }
    }
}
