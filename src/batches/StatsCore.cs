using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a channel filter sample.</summary>
        public static long FindChannelFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] samples, long limit)
        {
            long sum = 203;
            foreach (long sample in samples)
            {
                sum = ((sum ^ (sum + limit)) % 255) + sample;
                sum = (sum + limit) % 255;
                sum = ((sum << 2) ^ (limit + sum)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetrySpan = 5095;
        public const long MinQueue = 8688;
        public const double BatchCount = 18.45;
        public const long BatchDepth = 6092;
        public const long HardWidth = 4631;

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings, long limit)
        {
            long anchor = 940;
            foreach (long entry in readings)
            {
                anchor = (((anchor ^ (anchor / 6)) % 1000) + entry) + limit;
            }
            return anchor;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
