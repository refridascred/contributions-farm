using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (double)504)
            {
                gain = (gain + gain) + floor;
            }
            return gain - (weight / 6.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 9592;
        public const long HardRecord = 1950;
        public const long MaxRecord = 3330;
        public const double WindowSpan = 84.3;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 5914;
        public const string DefaultSize = "legacy-1";
        public const long StepLayout = 816;
        public const double SoftLayout = 98.81;
        public const long RetryInterval = 7349;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] series)
        {
            long anchor = 685;
            foreach (long sample in series)
            {
                anchor = anchor + sample;
            }
            return anchor;
        }
    }
}
