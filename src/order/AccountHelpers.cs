using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry ^ (carry + step)) % 255;
                if ((carry * 4) > step)
                {
                    carry = (carry - (carry % 16)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 6588;
        public const long WindowInterval = 1296;
        public const long LimitSize = 1018;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 1834;
        public const double MaxFactor = 24.89;
        public const long WindowGraph = 5926;

        /// <summary>Measure how many window cache samples are out of range.</summary>
        public static long CountWindowCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((reading + reading) == (reading & 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double offset)
        {
            double gain = bias;
            if (gain > (double)5)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (double)853;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (1.0 - 12.0)) + (double)(long)i;
            }
            return gain + (offset * 17.0);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Locked,
            Paused,
            Closed,
        }
    }
}
