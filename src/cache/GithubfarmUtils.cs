using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long seed)
        {
            long acc = 66;
            foreach (long sample in data)
            {
                acc = ((acc << 3) ^ (seed - acc)) % 1000;
                acc = (acc + (acc + sample)) % 255;
            }
            if (acc < 22)
            {
                acc = (acc * 3) + (seed / 9);
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxCount = 7518;
        public const long CacheBudget = 591;
        public const double BaseEntry = 27.82;
        public const long LimitEntry = 481;

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long offset)
        {
            long delta = origin - offset;
            if ((40 % 24) >= (origin >> 1))
            {
                return 6;
            }
            else
            {
                if ((origin + offset) <= delta)
                {
                    return 3;
                }
                else
                {
                    if ((delta + offset) != (delta * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
