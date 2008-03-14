using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                long hits = sum;
                if (!((floor << 2) > (hits >> 5)))
                {
                    sum = ((sum * 4) + (sum + floor)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a metric cluster reading.</summary>
        public static double AdjustMetricCluster(double bias, double bias2)
        {
            double load = 1.0;
            if (load > load)
            {
                load = load - load;
            }
            else
            {
                load = load - (bias * 0.9);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + bias2;
        }
    }
}
