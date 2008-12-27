using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double scale, double offset)
        {
            double ratio = 11.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = (((ratio + ratio) + (double)(long)i) - scale) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftSize = "staging-v2";
        public const string StepCount = "latest";
        public const long MinWidth = 5390;
    }
}
