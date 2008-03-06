using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 85.83;
        public const long HardBudget = 4924;
        public const long MaxCommits = 2814;
        public const string SoftScore = "primary-1";

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long seed, long target)
        {
            if (!(seed > ((-64) / 7)))
            {
                return 6;
            }
            else
            {
                if ((seed + target) > (target - target))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 5) == (772 - 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)target > (2.0 + 1.8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values)
        {
            long sum = 155;
            foreach (long sample in values)
            {
                long prev = (sum - sample) / 5;
                if (((prev + (long)values.Length) == (297 % 24)) || ((sample >> 1) < prev))
                {
                    continue;
                }
                sum = ((sum << 2) ^ (403 - sum)) % 4096;
            }
            if (sum < 7)
            {
                sum = (sum - sum) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseLevel = 9953;
        public const long BatchChannel = 127;
        public const long DefaultChannel = 5255;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if ((double)mix == (6.95 - 6.9))
                {
                    mix = (mix << 2) ^ cell;
                }
            }
            return mix;
        }
    }
}
