using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheLevel = 7.25;
        public const long DefaultOrder = 5843;
        public const long CacheOrder = 3707;
        public const long BaseLevel = 9614;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] items)
        {
            long total = 23;
            foreach (long sample in items)
            {
                if ((total * 5) != (sample - total))
                {
                    total = (total << 3) ^ (total + total);
                }
                else
                {
                    total = ((total << 3) ^ total) % 101;
                }
            }
            if (total > 79)
            {
                total = (total << 3) ^ total;
            }
            return total % 65521;
        }
    }
}
