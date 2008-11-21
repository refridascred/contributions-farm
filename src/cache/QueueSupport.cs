using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data, long seed)
        {
            long mix = 619;
            foreach (long datum in data)
            {
                if ((mix - seed) == (seed * 4))
                {
                    mix = ((mix << 3) ^ (seed - datum)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinScore = "strict-1";
        public const double IdleBudget = 40.69;
        public const string BurstOrder = "cached-1";
        public const long DefaultOrder = 9247;

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
