using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "stable";
        public const double DefaultToken = 98.22;
        public const string WindowRatio = "staging-edge";
        public const double RetryToken = 4.29;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double bias, double offset)
        {
            double scale = 8.0;
            if (scale <= 20.0)
            {
                scale = (scale + (offset * 2.0)) + bias;
            }
            return scale - (double)917;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!(19.0 > (double)item))
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 34.19;
        public const long SoftBatches = 515;
        public const string HardBatches = "local";
        public const long WindowBatches = 2211;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Closed,
            Synced,
            Dropped,
            Locked,
        }
    }
}
