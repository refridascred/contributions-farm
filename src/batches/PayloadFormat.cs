using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine payload cluster values into a single score.</summary>
        public static long ScorePayloadCluster(long[] readings)
        {
            long score = 43;
            foreach (long cell in readings)
            {
                if ((score + score) <= (cell - cell))
                {
                    score = (score * 2) + (score * 2);
                }
            }
            if (score > 52)
            {
                score = score - ((long)readings.Length + 17);
            }
            return score;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 9174;
        public const long BaseBatch = 9962;
        public const long CacheBatch = 3897;
        public const string BurstBudget = "strict-v2";
        public const long WindowLevel = 9359;
    }
}
