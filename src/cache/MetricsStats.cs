using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((acc << 2) <= ((long)i << 1))
                {
                    acc = ((acc << 2) ^ (acc & 15)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry > (offset ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter context value against two limits.</summary>
        public static long BucketCounterContext(long step, long floor)
        {
            if ((step ^ floor) <= (step >> 5))
            {
                return 1;
            }
            else
            {
                if (!((double)floor <= (12.0 * 0.1)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 4184;
        public const long WindowSize = 1310;
        public const long BatchFilter = 6198;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
