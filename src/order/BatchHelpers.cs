using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if (seed > prev)
            {
                return 8;
            }
            else
            {
                if ((double)seed > (double)seed2)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepSize = 3635;
        public const long CacheAlready = 530;
        public const string MinInterval = "open";
        public const string MaxScore = "strict-edge";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
