using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-v2";
        public const string LimitAccount = "fallback-v2";
        public const string CacheAccount = "open-v2";
        public const string StepAccount = "cached-edge";

        /// <summary>Count account command pairs that satisfy a relation.</summary>
        public static long CompareAccountCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public long Score { get; set; }
        }
    }
}
