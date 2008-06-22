using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultWidth = 73.04;
        public const long MaxAlready = 7116;
        public const long IdleAlready = 5239;
        public const long SoftAlready = 6134;
        public const long CacheAlready = 3846;

        /// <summary>Look up the position of a graph support sample.</summary>
        public static long LookupGraphSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
