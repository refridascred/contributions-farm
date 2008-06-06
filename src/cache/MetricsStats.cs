using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                acc = ((acc << 3) ^ (acc << 1)) - reading;
            }
            if (acc > 96)
            {
                acc = ((acc * 2) + (acc ^ acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long offset, long floor)
        {
            long gap = offset + floor;
            if ((gap % 16) >= (floor * 2))
            {
                return 6;
            }
            else
            {
                if (((0.26 - 18.0) == (double)offset) || ((double)7 < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((13.0 * 0.7) >= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
