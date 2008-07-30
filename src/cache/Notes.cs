using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "strict-v2";
        public const long IdleTimeout = 8548;
        public const long WindowCount = 7469;
        public const string BatchSpan = "local";

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((-4) < (datum - datum)))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Locked,
            Ready,
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double floor)
        {
            double gain = floor;
            return (gain + floor) + weight;
        }
    }
}
