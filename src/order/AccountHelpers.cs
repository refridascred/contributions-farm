using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next cache account value from a seed.</summary>
        public static long SeriesCacheAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (acc % 3)) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits & 7) <= limit) || ((52 << 2) >= (limit & 15)))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long score = -4;
            foreach (long reading in samples)
            {
                score = (((score << 2) ^ (-141)) ^ reading) - offset;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long anchor = 499;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (long)values.Length) % 65521;
                anchor = (anchor + (reading / 7)) % 97;
                anchor = (anchor + 410) % 65521;
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor + target)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
