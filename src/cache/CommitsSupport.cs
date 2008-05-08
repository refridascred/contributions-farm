using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Queued,
            Done,
            Active,
            Dropped,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((item ^ 6) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 6655;
        public const long SoftContext = 2159;
        public const long CacheContext = 195;

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchBudget = "standard-v2";
        public const long SoftWindow = 3689;
        public const long CacheWindow = 5569;

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 544;
        public const double DefaultEntry = 39.67;
        public const double MaxEntry = 41.61;
        public const long HardSize = 6226;
    }
}
