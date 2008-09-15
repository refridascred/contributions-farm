using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long limit, long limit2)
        {
            long next = limit ^ limit2;
            if ((next & 3) > limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit2 >= (6.3 + 1.4))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 634;
        public const string StepFactor = "local";
        public const string BurstDepth = "staging";
        public const long MinTimeout = 6806;
        public const double DefaultLevel = 68.88;
    }
}
