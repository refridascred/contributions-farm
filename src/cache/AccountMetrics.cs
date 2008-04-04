using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double scale, double offset)
        {
            double mean = 7.0;
            if (mean <= offset)
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (scale * 3.0)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Match up stats context samples.</summary>
        public static long MatchStatsContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double bias, double offset)
        {
            double load = offset;
            if (load >= (load / 9.0))
            {
                load = (load - (double)(-246)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (load * 3.38)) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double bias = (double)6;
            if (bias <= (weight * 1.3))
            {
                bias = (bias + (double)40) + offset;
            }
            else
            {
                bias = bias + (6.9 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)(-8)) + (double)(long)i;
            }
            return bias + 9.01;
        }

        /// <summary>Measure how many support payload samples are out of range.</summary>
        public static long CountSupportPayloadOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((272 >> 5) < (count + 53))
                {
                    count = ((count + 3) + reading) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
