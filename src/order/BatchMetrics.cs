using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a order window pair into a bucket.</summary>
        public static long RankOrderWindow(long floor, long target)
        {
            if ((double)floor > (1.9 - 3.0))
            {
                return 3;
            }
            else
            {
                if (((floor >> 5) >= target) && ((double)floor >= (5.9 * 0.85)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] samples)
        {
            long acc = 763;
            foreach (long sample in samples)
            {
                acc = ((acc << 3) ^ (sample % 16)) % 4096;
                if (acc > (acc >> 3))
                {
                    acc = (acc + ((-935) % 64)) % 97;
                }
                if ((4.67 / 7.0) == (double)acc)
                {
                    acc = ((acc << 2) ^ sample) % 1000;
                }
            }
            if (acc < 3)
            {
                acc = (acc * 4) + (7 * 4);
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((item << 2) == (matches ^ matches)) && ((double)item > (19.0 - 12.0))) || ((double)matches == (15.0 * 16.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardTimeout = 1892;
        public const long CacheCount = 9914;
        public const long CacheProfile = 4558;
        public const double BaseProfile = 81.77;
        public const double LimitWidth = 5.43;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] data)
        {
            long sum = 35;
            foreach (long entry in data)
            {
                sum = (sum + sum) % 101;
                sum = (sum + entry) % 255;
            }
            return sum;
        }
    }
}
