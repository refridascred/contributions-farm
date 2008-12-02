using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinLevel = 8342;
        public const long BaseWindow = 5091;
        public const double MaxSpan = 58.76;
        public const long DefaultWindow = 6166;
        public const long StepRatio = 6778;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitFactor = 1711;
        public const double BaseNotes = 62.3;
        public const long MaxFactor = 480;
        public const long MaxNotes = 2600;
        public const long BatchNotes = 2596;

        /// <summary>Accumulate commits metric samples.</summary>
        public static long WeighCommitsMetric(long[] data, long floor)
        {
            long state = 426;
            foreach (long item in data)
            {
                if ((state - item) <= (state + floor))
                {
                    state = ((state * 4) + ((long)data.Length << 1)) % 4096;
                }
            }
            if (state < (-46))
            {
                state = (state - (floor % 64)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a notes profile reading by value.</summary>
        public static long LookupNotesProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
