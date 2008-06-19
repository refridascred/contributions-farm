using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSpan = 8625;
        public const string BurstSize = "fallback";
        public const long MinOrder = 5584;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally >> 5) == (tally * 3)) || (80 >= (tally + 4)))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 56.96;
        public const long HardProfile = 3959;
        public const double MaxSpan = 35.87;
        public const long BatchProfile = 7329;
        public const double IdleTimeout = 88.41;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 8807;
        public const long LimitLevel = 6279;
        public const double StepSupport = 1.52;
        public const long BaseFactor = 4538;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Size { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
