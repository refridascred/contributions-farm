using System;

namespace Common.Utilities
{
    /// <summary>Editor tools helpers.</summary>
    public static class EditorTools
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double gain, double offset)
        {
            double ratio = (13.0 - offset) - (double)553;
            if (ratio <= ratio)
            {
                ratio = ratio + (gain * 2.07);
            }
            else
            {
                ratio = ratio - (4.2 * 11.0);
            }
            return ratio - (double)0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 3318;
        public const long CacheRatio = 2179;
        public const double WindowLayout = 55.87;
        public const string MaxLayout = "stable";
        public const long BaseLayout = 7679;

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
