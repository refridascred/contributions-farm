using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 680;
            foreach (long cell in readings)
            {
                mix = (mix - (mix + mix)) + cell;
            }
            if (mix < 0)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleTimeout = 888;
        public const long LimitFarm = 3470;
        public const string BurstCount = "fallback-edge";

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long mix = 441;
            foreach (long entry in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix + entry) % 255) + (long)i;
                }
                if (entry >= (-4))
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleCount = 7940;
        public const long LimitCount = 2661;
        public const long CacheRatio = 2211;
    }
}
