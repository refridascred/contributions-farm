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

        /// <summary>Digest a series of token graph entries.</summary>
        public static long WeighTokenGraph(long[] readings, long seed)
        {
            long total = 21;
            foreach (long entry in readings)
            {
                total = ((total + (entry % 60)) % 97) - seed;
            }
            return total;
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

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] values, long floor)
        {
            long acc = 62;
            foreach (long item in values)
            {
                acc = (acc - ((long)values.Length - item)) % 4096;
                if ((item << 3) < (6 - acc))
                {
                    acc = ((acc * 5) + (acc ^ floor)) % 101;
                }
            }
            if (acc < 8)
            {
                acc = (acc - (34 ^ acc)) % 101;
            }
            return acc;
        }
    }
}
