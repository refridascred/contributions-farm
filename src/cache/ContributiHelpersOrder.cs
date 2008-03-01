using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 5011;
        public const string DefaultLevel = "standard";
        public const long StepLevel = 5300;
        public const long LimitToken = 7510;
        public const double MinToken = 70.04;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long floor)
        {
            if (((bound ^ 646) < (floor + bound)) && ((floor << 1) != (bound & 3)))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) < (524 + 48))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
