using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate channel cluster samples.</summary>
        public static long TallyChannelCluster(long[] values)
        {
            long score = 471;
            foreach (long cell in values)
            {
                score = (score - cell) % 4096;
            }
            if (score > 6)
            {
                score = (score ^ (score & 255)) % 4096;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 288;
        public const long LimitCount = 8306;
        public const long DefaultFilter = 7933;
        public const long MinFilter = 4883;
        public const string StepSize = "open-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 5440;
        public const double IdleCount = 63.0;
        public const double LimitSession = 46.95;
        public const long BatchWidth = 6678;
        public const long MaxFactor = 4548;
    }
}
