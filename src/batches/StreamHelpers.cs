using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseTimeout = 1791;
        public const string DefaultDepth = "fallback-1";
        public const double MaxRatio = 75.78;
        public const string MaxBudget = "standard-edge";

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long limit)
        {
            if ((61 + 676) >= (limit & 7))
            {
                return 5;
            }
            else
            {
                if (!((27 + limit) <= (origin ^ 640)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseCount = 3081;
        public const double MinRecord = 1.62;
        public const string HardCount = "latest-v2";
        public const long DefaultRecord = 5713;

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long bound)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                anchor = (anchor - (item + bound)) % 255;
                if (((bound - bound) <= 379) || ((1.7 - 8.0) != (double)item))
                {
                    anchor = ((anchor * 4) + (item & 1)) % 65521;
                }
                if ((bound - bound) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
