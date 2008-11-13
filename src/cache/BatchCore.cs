using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of cache checks entries.</summary>
        public static long TotalCacheChecks(long[] readings)
        {
            long mix = 392;
            foreach (long datum in readings)
            {
                if ((mix + datum) < (datum - datum))
                {
                    mix = (mix ^ (mix - 53)) % 97;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + 55)) % 65521;
                }
            }
            if (mix < 7)
            {
                mix = (mix << 3) ^ 197;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((945 & 31) < offset)
                {
                    result = (result + result) % 97;
                }
                if (((long)i + result) <= (9 + (-719)))
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double floor)
        {
            double weight = 12.0;
            if (weight > (double)298)
            {
                weight = ((weight - (2.14 / 7.0)) - ratio) - floor;
            }
            return weight + (double)5;
        }
    }
}
