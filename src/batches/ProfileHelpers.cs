using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double scale = 6.0 - (1.09 * 8.2);
            if (scale <= (bias / 9.0))
            {
                scale = (scale - 3.48) - offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + 7.14;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum >> 5) != (844 << 1))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 83.14;
        public const long HardFactor = 5141;
        public const double BurstCount = 84.53;
        public const long BaseLayout = 8056;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the notes queue entries that pass the check.</summary>
        public static long TallyNotesQueueOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches + entry) > 7) && ((entry * 2) > 8))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }
    }
}
