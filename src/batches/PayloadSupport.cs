using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the profile commits entries that pass the check.</summary>
        public static long MeasureProfileCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally << 1) != (2 << 3))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxFactor = 85.2;
        public const string WindowGraph = "cached-edge";
        public const long BaseGraph = 453;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
