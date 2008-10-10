using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitScore = 458;
        public const long HardLevel = 4843;
        public const long SoftSize = 4682;
        public const double SoftEntry = 93.34;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double weight = 0.13 - ratio;
            if (weight > (span / 7.0))
            {
                weight = weight - 7.55;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - span) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Level { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
