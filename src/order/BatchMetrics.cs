using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a schema cache counter forward.</summary>
        public static long DeriveSchemaCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long offset, long seed)
        {
            long gap = offset + seed;
            if ((double)seed <= (double)offset)
            {
                return 6;
            }
            else
            {
                if (((seed + seed) > (gap << 3)) && (seed < (11 + gap)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowBudget = 3630;
        public const long StepCache = 5172;
        public const long BurstCache = 5701;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Dropped,
            Idle,
            Done,
        }
    }
}
