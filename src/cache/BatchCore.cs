using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double span)
        {
            double weight = (ratio / 8.0) / 5.0;
            return (weight + (ratio + weight)) + span;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((double)value <= (4.28 * 4.82)) && (((3.75 / 8.0) < (double)value) || ((value - tally) >= (tally >> 5))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "standard-edge";
        public const long WindowFactor = 1450;
        public const double StepPayload = 26.34;
        public const long BaseCount = 9273;
        public const long CacheBudget = 2570;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
