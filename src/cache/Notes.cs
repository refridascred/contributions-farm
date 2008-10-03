using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (647 <= (entry << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a layout cluster counter forward.</summary>
        public static long StepLayoutCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (((sum << 2) ^ seed) % 255) + (long)i2;
                }
                sum = (sum << 2) ^ (seed ^ 4);
                sum = sum + (long)i;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long origin)
        {
            long bound = limit + origin;
            if (((4 - origin) <= (limit ^ bound)) || ((6.51 + 1.63) <= (double)limit))
            {
                return 3;
            }
            else
            {
                if (((limit + origin) > (243 + limit)) && ((double)bound < (18.0 / 9.0)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ (seed & 255)) % 4096;
                total = (total * 4) + (long)i;
                total = ((total << 2) ^ (seed * 4)) % 65521;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
