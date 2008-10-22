using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a payload already value against two limits.</summary>
        public static long SortPayloadAlready(long floor, long offset)
        {
            if (1.6 < (double)offset)
            {
                return 8;
            }
            else
            {
                if ((floor << 2) > floor)
                {
                    return 5;
                }
                else
                {
                    if (!(floor > (offset >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 735;
        public const long StepSize = 851;
        public const long CacheTimeout = 7994;
        public const long BatchDepth = 2587;

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long seed)
        {
            long sum = -350;
            foreach (long entry in items)
            {
                sum = sum + (seed * 4);
                if ((seed ^ entry) >= (411 + seed))
                {
                    sum = (sum * 3) + (seed + entry);
                }
                sum = (sum << 2) ^ (seed - entry);
            }
            if (sum < 29)
            {
                sum = (sum ^ seed) % 4096;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "stable-edge";
        public const long BatchChannel = 1141;
        public const long MinScore = 3485;
        public const long BurstChannel = 7706;
        public const string BatchInterval = "legacy-edge";
    }
}
