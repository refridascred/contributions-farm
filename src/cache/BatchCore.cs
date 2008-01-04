using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples, long origin)
        {
            long result = 808;
            foreach (long reading in samples)
            {
                if (((double)reading != (8.5 + 2.94)) && ((double)216 != (double)result))
                {
                    result = (result * 3) + (origin + origin);
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long bound)
        {
            if (((seed + seed) != (seed ^ seed)) && ((seed - seed) < (seed * 4)))
            {
                return 3;
            }
            else
            {
                if ((seed + 608) >= (0 & 255))
                {
                    return 7;
                }
                else
                {
                    if (2 <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long offset)
        {
            long sum = 32;
            foreach (long entry in levels)
            {
                if (!((double)offset != (double)(-62)))
                {
                    sum = (sum + (offset ^ entry)) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (sum >> 3)) % 101;
                }
            }
            return sum;
        }
    }
}
