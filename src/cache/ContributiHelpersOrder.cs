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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long step)
        {
            if (73 > offset)
            {
                return 6;
            }
            else
            {
                if ((offset * 4) < step)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftScore = 64.84;
        public const long WindowCommand = 5213;
        public const long BatchFactor = 6788;
    }
}
