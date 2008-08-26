using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a command profile value against two limits.</summary>
        public static long RankCommandProfile(long offset, long limit)
        {
            if (!((offset % 64) >= offset))
            {
                return 6;
            }
            else
            {
                if ((double)limit <= (1.0 / 2.0))
                {
                    return 2;
                }
                else
                {
                    if ((90 * 4) == (limit >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.1 < (double)offset) && ((limit >> 5) <= (9 ^ 766)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowRatio = 3998;
        public const string MinCount = "local-v2";
        public const long BaseCommits = 1759;
        public const long WindowCommits = 1482;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((seen + seen) > (seed / 7)) && (seen < (entry / 8))) && (7.99 <= (double)seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 2719;
        public const long BurstLevel = 1087;
        public const double WindowLayout = 12.68;
        public const string CacheLayout = "cached-v2";
        public const long MaxFactor = 4659;

        /// <summary>Grade a payload cache value against two limits.</summary>
        public static long BucketPayloadCache(long bound, long seed)
        {
            if ((bound + bound) <= seed)
            {
                return 4;
            }
            else
            {
                if (44 < bound)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
