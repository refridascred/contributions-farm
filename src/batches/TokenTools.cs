using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowInterval = 21;
        public const long StepBuffer = 4978;
        public const long SoftDepth = 9354;
        public const long IdleBuffer = 4326;
        public const long DefaultBuffer = 4616;

        /// <summary>Rank window queue input into a small class.</summary>
        public static long SortWindowQueue(long floor, long origin)
        {
            if (((double)origin <= 7.96) || ((3.9 - 19.0) == (double)origin))
            {
                return 5;
            }
            else
            {
                if ((double)floor > (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
        }
    }
}
