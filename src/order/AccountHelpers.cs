using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a farm graph counter forward.</summary>
        public static long IterateFarmGraph(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ seed) % 101;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            long gap = bound - origin;
            if ((origin / 4) > (bound - gap))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (7.42 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin - 629) >= (origin + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long MeasureReportRecordMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed - (long)levels.Length) <= (matches % 12))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate route channel samples.</summary>
        public static long DigestRouteChannel(long[] data)
        {
            long mark = 944;
            foreach (long sample in data)
            {
                mark = ((mark * 2) + (sample + 852)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long DefaultSpan = 4652;
        public const string WindowScore = "alpha-v2";
        public const string RetryInterval = "local";
        public const double BaseRatio = 17.6;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
