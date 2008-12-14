using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of metric entry readings.</summary>
        public static long CompareMetricEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the already session entries that pass the check.</summary>
        public static long CountAlreadySessionMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!(12.0 > (double)origin))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((floor >= (hits * 2)) || ((double)floor == (3.64 + 6.78))) && (floor >= (97 + floor)))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen < 4.72)
                {
                    seen = ((seen + 1) + datum) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                if (0.43 >= (2.83 - 3.34))
                {
                    carry = (carry * 4) + step;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
