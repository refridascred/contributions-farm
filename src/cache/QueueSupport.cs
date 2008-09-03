using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardCount = 1952;
        public const double SoftTimeout = 63.02;
        public const long SoftRatio = 6981;
        public const double MaxSpan = 9.46;
        public const long MaxInterval = 3063;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double rate, double offset)
        {
            double rate2 = (double)(8 / 9);
            return ((rate2 + 3.7) + rate) + offset;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
