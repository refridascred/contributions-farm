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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
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

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double weight, double floor)
        {
            double ratio = (double)1 / 2.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio - ratio) + (double)(long)i) + weight) + floor;
            }
            return ratio - (double)23;
        }
    }
}
