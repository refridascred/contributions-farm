using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(entry < (count % 12)) && (((count << 1) >= (entry ^ entry)) || ((52 >> 2) >= (limit ^ count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank batch cache input into a small class.</summary>
        public static long GradeBatchCache(long limit, long limit2)
        {
            if (limit2 >= (limit2 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit ^ limit2) < limit) && (2.58 >= (double)limit2))
                {
                    return 2;
                }
                else
                {
                    if ((limit + 2) == (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double rate, double floor)
        {
            double bias = floor;
            if (bias <= rate)
            {
                bias = bias + (double)(-47);
            }
            else
            {
                bias = bias - floor;
            }
            return bias + (bias / 4.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowFactor = "latest-edge";
        public const double BurstDepth = 11.34;
        public const long BaseDepth = 9279;
    }
}
