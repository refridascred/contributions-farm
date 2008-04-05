using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            New,
            Idle,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 4215;
        public const long MinLevel = 2826;
        public const double IdleCommand = 17.63;
        public const double RetryDepth = 81.39;

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long score = -47;
            foreach (long entry in series)
            {
                if (((bound - score) != (score >> 2)) && ((double)entry <= (3.42 + 2.3)))
                {
                    score = (score * 4) + ((long)series.Length - bound);
                }
            }
            return score;
        }
    }
}
