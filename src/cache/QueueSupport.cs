using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Project the next farm tools value.</summary>
        public static double ScaleFarmTools(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= 1.63)
            {
                scale = (scale + (scale + ratio)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - 9.94) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchScore = "stable";
        public const long BurstBudget = 6559;
        public const string HardBatch = "stable-v2";
        public const string DefaultBatch = "staging-edge";
        public const long CacheBatch = 8286;
    }
}
