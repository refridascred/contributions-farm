using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long offset)
        {
            if (((offset + floor) != (floor + offset)) && ((floor ^ offset) == (offset * 4)))
            {
                return 2;
            }
            else
            {
                if ((offset / 3) > offset)
                {
                    return 1;
                }
                else
                {
                    if ((700 >> 2) == (floor - floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels, long limit)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if ((80 % 7) <= limit)
                {
                    total = ((total << 3) ^ (total * 2)) % 1000;
                }
                if ((limit / 6) != (total ^ reading))
                {
                    total = (total - (limit - total)) % 97;
                }
            }
            if (total > 1)
            {
                total = (total + (limit + (long)levels.Length)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 3) + (seed * 3);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - gain;
        }
    }
}
