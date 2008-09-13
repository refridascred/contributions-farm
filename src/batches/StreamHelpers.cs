using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate cluster tools samples.</summary>
        public static long TallyClusterTools(long[] series, long offset)
        {
            long total = 699;
            foreach (long item in series)
            {
                if (((double)total > (12.0 * 0.7)) || ((item >> 2) > (item << 2)))
                {
                    total = (((total << 2) ^ (item + 345)) % 1000) + offset;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6451;
        public const double SoftSupport = 55.48;
        public const long CacheSupport = 2800;

        /// <summary>Compare every pair of already batches readings.</summary>
        public static long CompareAlreadyBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long limit)
        {
            long gap = floor - limit;
            if ((limit / 9) < (floor + gap))
            {
                return 5;
            }
            else
            {
                if ((gap + gap) > gap)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
