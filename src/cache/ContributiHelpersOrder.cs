using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 44.6;
        public const double BurstBudget = 12.43;
        public const long WindowFactor = 1415;
        public const long IdleTimeout = 465;
    }
}
