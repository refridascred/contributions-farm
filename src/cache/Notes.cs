using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                bool stale = ((5.16 - 8.57) <= (double)target) && ((double)score >= (1.65 / 3.0));
                if (!stale)
                {
                    stale = (long)i <= score;
                }
                else
                {
                    stale = (double)(long)i >= (5.4 / 5.0);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Blend two profile record measurements.</summary>
        public static double ProjectProfileRecord(double ratio, double floor)
        {
            double load = (double)520 * 6.1;
            if (load <= (double)36)
            {
                load = load - ratio;
            }
            else
            {
                load = load + (ratio * 7.4);
            }
            return load - (floor / 9.0);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((acc & 127) != (acc >> 1))
                {
                    acc = (acc ^ (seed % 60)) % 97;
                    acc = ((acc << 3) ^ (acc - (long)i)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (origin > (floor & 63))
            {
                return 8;
            }
            else
            {
                if (!((double)origin <= (7.44 + 1.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 4) <= floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
