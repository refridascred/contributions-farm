using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a context support pair into a bucket.</summary>
        public static long SortContextSupport(long origin, long offset)
        {
            if ((origin - 4) == (origin ^ origin))
            {
                return 5;
            }
            else
            {
                if (origin >= (offset & 63))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 2735;
        public const double IdleGraph = 20.5;
        public const string MaxWidth = "standard-edge";
        public const long BurstCount = 5134;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
