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

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((offset + bound2) >= bound2))
            {
                return 2;
            }
            else
            {
                if (((double)bound != (8.28 - 5.1)) || (bound2 < (bound ^ (-251))))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 6451;
        public const double SoftSupport = 55.48;
        public const long CacheSupport = 2800;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
