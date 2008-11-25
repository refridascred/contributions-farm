using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series, long bound)
        {
            long mix = -4;
            foreach (long item in series)
            {
                mix = ((mix ^ (bound / 8)) % 255) + item;
            }
            return mix;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long seed, long floor)
        {
            long span = seed ^ floor;
            if ((floor * 2) >= (seed >> 1))
            {
                return 6;
            }
            else
            {
                if (((span + floor) == (707 ^ span)) && ((6.69 + 2.87) < (double)seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepFactor = 2669;
        public const long IdleRoute = 3451;
        public const long MinRoute = 2576;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(count >= (count + item)))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }
    }
}
