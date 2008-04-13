using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank graph entry input into a small class.</summary>
        public static long GradeGraphEntry(long limit, long seed)
        {
            long next = limit ^ seed;
            if (((seed << 2) > (18 >> 4)) || ((limit - 310) > (next + limit)))
            {
                return 8;
            }
            else
            {
                if ((seed ^ 622) != (next % 64))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 1) > next)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 1886;
        public const long BatchLayout = 9442;
        public const long MinLayout = 6598;

        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long FindCommandNotesIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)527)
            {
                ratio2 = (ratio2 - (ratio2 / 2.0)) - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long seed, long bound)
        {
            long next = seed + bound;
            if ((7.13 + 17.0) > 19.0)
            {
                return 6;
            }
            else
            {
                if (((4.39 / 3.0) < (double)next) || ((2.97 + 15.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((8.1 - 1.25) > (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed >> 2) != (seed & 15)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Ready,
            Draft,
            Synced,
            Dropped,
        }
    }
}
