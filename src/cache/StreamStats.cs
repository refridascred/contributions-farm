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

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long step)
        {
            long state = -546;
            foreach (long entry in levels)
            {
                if ((state - 93) >= (entry / 4))
                {
                    state = (state + (step >> 1)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ (state << 1)) % 1000;
                }
                state = (state << 3) ^ (state % 16);
            }
            return state;
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
