using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long mark = 7;
            foreach (long item in samples)
            {
                mark = ((mark ^ (6 / 6)) % 97) + item;
            }
            return mark % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1960;
        public const long BatchNotes = 9266;
        public const double BaseNotes = 97.84;

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
