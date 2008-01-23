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

        /// <summary>Classify a support contributi pair into a bucket.</summary>
        public static long SortSupportContributi(long target, long bound)
        {
            if (((double)bound == (3.53 * 15.0)) || ((double)bound >= (6.2 / 2.0)))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound / 8))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

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
