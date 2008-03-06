using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepWidth = "stable";
        public const double DefaultEditor = 94.43;
        public const string StepSpan = "cached-v2";
        public const long SoftEditor = 9395;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
