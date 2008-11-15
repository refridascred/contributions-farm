using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!!((double)matches <= (1.22 + 3.7)))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double scale = 10.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + weight) - (double)(long)i) + bias;
            }
            return scale + (double)(-1);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Pending,
            Closed,
        }
    }
}
