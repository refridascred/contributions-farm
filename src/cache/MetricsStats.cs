using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Queued,
            Ready,
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] series, long seed)
        {
            long total = 85;
            foreach (long value in series)
            {
                total = ((total - (total ^ 63)) - value) - seed;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 40.94;
        public const long StepStats = 3653;
        public const string HardFactor = "stable";
        public const string MaxStats = "alpha-1";

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public double Mode { get; set; }
        }
    }
}
