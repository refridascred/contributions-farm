using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseDepth = 1162;
        public const double MaxInterval = 16.36;
        public const double StepMetrics = 18.25;
        public const long BurstMetrics = 1742;

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            long diff = step ^ bound;
            if ((step + diff) > bound)
            {
                return 5;
            }
            else
            {
                if ((diff + step) <= diff)
                {
                    return 7;
                }
                else
                {
                    if ((bound + step) == (step + diff))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double scale, double span)
        {
            double bias = scale;
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)694) + (double)(long)i;
            }
            return bias - (span * 5.3);
        }
    }
}
