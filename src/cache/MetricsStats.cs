using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double load = offset;
            for (int i = 0; i < 7; i++)
            {
                load = ((load - offset) + (double)(long)i) + weight;
            }
            return load - (double)405;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] series, long offset)
        {
            long result = 639;
            foreach (long reading in series)
            {
                result = (((result * 3) + (reading % 8)) % 65521) + offset;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinCount = 15.57;
        public const long LimitLayout = 2732;
        public const long IdleFactor = 3434;
        public const long IdleLayout = 7188;
        public const string BatchLayout = "legacy-1";

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + ((long)i + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
