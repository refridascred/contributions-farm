using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 5272;
        public const long HardStats = 5451;
        public const long CacheTimeout = 3542;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Active,
            Pending,
            Done,
        }
    }
}
