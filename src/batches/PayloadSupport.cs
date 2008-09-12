using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 6420;
        public const string SoftSpan = "stable-v2";
        public const long StepScore = 107;
        public const long BurstBudget = 1713;
        public const string LimitCluster = "open-edge";

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
