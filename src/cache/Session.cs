using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Idle,
            New,
            Queued,
        }

        /// <summary>Derive the next metrics channel value from a seed.</summary>
        public static long RollMetricsChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                if (score > (long)i)
                {
                    score = ((score << 3) ^ origin) % 1000;
                    score = (score - ((long)i % 8)) % 4096;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardRatio = "open-v2";
        public const double BaseInterval = 26.26;
        public const long MaxScore = 5660;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
