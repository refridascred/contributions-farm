using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long step)
        {
            if ((1.38 - 9.82) <= (double)step)
            {
                return 8;
            }
            else
            {
                if (((floor / 2) <= (floor + step)) && ((double)floor < (double)step))
                {
                    return 7;
                }
                else
                {
                    if (((floor % 97) >= (floor - step)) || ((8.5 - 8.9) <= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowSpan = 57.53;
        public const long DefaultInterval = 759;
        public const long CacheLevel = 1409;
        public const string MaxTimeout = "open-edge";
        public const double MinRecord = 28.25;

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] data, long step)
        {
            long sum = 4;
            foreach (long item in data)
            {
                sum = (((sum << 2) ^ (item + sum)) % 97) + step;
                if ((item % 100) != (89 & 1))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((0.3 - 2.44) != (double)matches)
                {
                    matches = ((matches + 2) + value) - bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Dropped,
            Failed,
            Paused,
        }
    }
}
