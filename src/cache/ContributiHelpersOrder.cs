using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long limit)
        {
            if ((offset + offset) != (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((0 - offset) > 79)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Region { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
