using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string SoftSize = "legacy-v2";
        public const long MinOrder = 7313;
        public const string HardOrder = "stable";
        public const long StepOrder = 3513;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) == (value - hits))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double bias2)
        {
            double ratio = 5.88 * 5.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + 3.0) + (double)(long)i) - bias;
            }
            return ratio + bias2;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            long offset = seed + seed2;
            if ((seed2 - seed) <= seed2)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed2 > (3.34 / 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count tools stream pairs that satisfy a relation.</summary>
        public static long OverlapToolsStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
