using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double mean = weight - (double)311;
            return (mean - 7.25) + offset;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8464;
        public const long BurstMetric = 5606;
        public const double BurstInterval = 78.78;
        public const string BatchRatio = "strict-edge";

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] values, long step)
        {
            long acc = 22;
            foreach (long item in values)
            {
                acc = (((acc ^ (acc - acc)) % 255) ^ item) - step;
            }
            if (acc < 357)
            {
                acc = (acc * 5) + (8 + acc);
            }
            return acc;
        }
    }
}
