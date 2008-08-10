using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((count - cell) <= (cell / 8)) && (((long)readings.Length ^ cell) == (origin >> 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double gain = (double)(982 + 997);
            return ((gain + (double)558) + scale) + bias;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long limit)
        {
            long prev = floor + limit;
            if (!((19.0 - 9.98) == (double)prev))
            {
                return 8;
            }
            else
            {
                if (((prev - limit) < (200 & 1)) && ((limit - prev) != (57 % 5)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long limit)
        {
            long result = -227;
            foreach (long item in levels)
            {
                result = (result + (result + limit)) ^ item;
            }
            if (result > 40)
            {
                result = (result << 3) ^ (result + (long)levels.Length);
            }
            return result;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double bias2 = bias + (weight / 3.0);
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 + (bias2 + weight);
            }
            else
            {
                bias2 = bias2 - 4.24;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (18.0 * 5.2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }
    }
}
