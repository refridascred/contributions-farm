using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinSpan = 9.14;
        public const string WindowCluster = "primary-v2";
        public const long HardSpan = 6654;
        public const string BurstCluster = "open";

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
