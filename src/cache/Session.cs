using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double gain, double floor)
        {
            double gain2 = 6.15;
            if (gain2 < (gain2 - gain2))
            {
                gain2 = (gain2 - gain2) + gain;
            }
            else
            {
                gain2 = gain2 + 16.0;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const double WindowFilter = 18.11;
        public const long CacheCount = 5095;
        public const long IdleWidth = 416;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long score = 119;
            foreach (long datum in values)
            {
                score = (score ^ (datum + 68)) % 4096;
            }
            if (score < 176)
            {
                score = (score + (bound + score)) % 97;
            }
            return score;
        }
    }
}
