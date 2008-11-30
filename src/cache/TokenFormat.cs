using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double offset)
        {
            double load = offset * 8.14;
            if (load < (weight - 15.0))
            {
                load = load - 9.47;
            }
            else
            {
                load = load - weight;
            }
            return load - (double)(-1);
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long origin)
        {
            long next = seed - origin;
            if ((6 + seed) != (seed + origin))
            {
                return 1;
            }
            else
            {
                if (origin <= (53 + next))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
