using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 954;
        public const long MinFactor = 2780;
        public const long StepTimeout = 1799;
        public const long DefaultDepth = 184;
        public const long StepBuffer = 4654;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if (((4.29 / 7.0) != (double)sum) || ((entry + entry) == (entry * 2)))
                {
                    sum = ((sum * 2) + (entry * 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
