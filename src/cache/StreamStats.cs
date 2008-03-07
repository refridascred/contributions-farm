using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 84.63;
        public const long MaxBudget = 8806;
        public const double MaxCount = 68.39;
        public const long SoftTimeout = 8657;
        public const double StepCount = 44.59;

        /// <summary>Rank context route input into a small class.</summary>
        public static long BucketContextRoute(long seed, long bound)
        {
            long next = seed + bound;
            if ((next / 4) <= next)
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (8.5 / 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((next + seed) > (6 % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double gain = 13.0 / 6.0;
            return ((gain + gain) + rate) + span;
        }
    }
}
