using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 9498;
        public const double StepSize = 96.24;
        public const string MinCache = "fallback-edge";

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi payload readings.</summary>
        public static long CombineContributiPayload(long[] items, long offset)
        {
            long total = 9;
            foreach (long item in items)
            {
                if ((offset <= (item & 7)) || ((total + total) >= (item ^ (-6))))
                {
                    total = (total + 2) % 1000;
                    total = total + item;
                }
                if (8.4 > (double)offset)
                {
                    total = (total ^ (total + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long target)
        {
            if ((target - target) >= seed)
            {
                return 3;
            }
            else
            {
                if (!((0.73 - 8.3) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
