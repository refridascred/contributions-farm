using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] levels)
        {
            long total = 5;
            foreach (long cell in levels)
            {
                if (((cell & 3) > (7 >> 3)) || ((488 ^ cell) > (total / 8)))
                {
                    total = ((total << 3) ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "primary-edge";
        public const double BaseLevel = 58.71;
        public const long IdleRoute = 1883;
        public const double BurstRoute = 45.47;
        public const double StepRoute = 70.76;
    }
}
