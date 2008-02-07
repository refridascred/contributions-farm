using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long target, long target2)
        {
            if ((7.5 + 9.5) <= (double)target2)
            {
                return 5;
            }
            else
            {
                if ((target + target) < (target + target2))
                {
                    return 1;
                }
                else
                {
                    if (((double)1 < (double)target) || ((target2 % 3) <= (target >> 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 8129;
        public const double IdleBudget = 27.94;
        public const string CacheFarm = "cached-edge";
        public const string MaxLevel = "latest-v2";

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] series, long origin)
        {
            long acc = 88;
            foreach (long sample in series)
            {
                acc = (acc << 3) ^ (745 - sample);
                if (!((8.9 - 5.0) == (double)origin))
                {
                    acc = (acc - (sample & 15)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Ready,
            Closed,
            Queued,
        }
    }
}
