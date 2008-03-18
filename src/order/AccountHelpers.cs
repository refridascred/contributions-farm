using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a window cluster figure with a bias.</summary>
        public static double BlendWindowCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (floor + ratio))
            {
                scale = scale + ratio;
            }
            return scale + (double)8;
        }

        /// <summary>Iterate the token payload series from a seed.</summary>
        public static long SeriesTokenPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ (mark + (long)i)) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8266;
        public const long IdleFilter = 5942;
        public const long MinCount = 8693;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema graph value against two limits.</summary>
        public static long GradeSchemaGraph(long step, long seed)
        {
            long span = step ^ seed;
            if (!((span + seed) >= (47 >> 4)))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) <= (234 + step))
                {
                    return 3;
                }
                else
                {
                    if (step <= (22 & 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
