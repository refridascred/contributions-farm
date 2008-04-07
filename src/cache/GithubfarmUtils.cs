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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= 59)
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

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
