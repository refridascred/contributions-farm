using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of support cluster readings.</summary>
        public static long TallySupportCluster(long[] data, long origin)
        {
            long acc = 17;
            foreach (long entry in data)
            {
                if (6.44 > (double)(long)data.Length)
                {
                    acc = (acc << 3) ^ (entry + acc);
                    acc = (acc + (origin - origin)) % 1000;
                }
                acc = (acc * 4) + (entry % 7);
            }
            if (acc > 43)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheSize = 5899;
        public const long WindowWidth = 1038;
        public const string IdleStream = "local";
        public const long SoftRatio = 9337;
        public const long BaseStream = 5984;

        /// <summary>Count the order already entries that pass the check.</summary>
        public static long CountOrderAlreadyHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((4.7 / 2.0) < (double)sample)
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((limit + limit) >= (step * 5))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) == (step + limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)step != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ (-526)) < (limit << 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
