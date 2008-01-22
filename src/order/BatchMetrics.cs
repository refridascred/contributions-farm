using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 8745;
        public const long DefaultDepth = 4003;
        public const string LimitSession = "fallback-1";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Paused,
            Ready,
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxBudget = "legacy-v2";
        public const long CacheSchema = 5396;
        public const long BatchInterval = 8030;
        public const double MaxFactor = 8.0;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry ^ tally) >= (tally + (-35)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
