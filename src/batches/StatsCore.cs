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

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc ^ (floor + floor)) % 1000;
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
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

        /// <summary>Locate a cache token reading by value.</summary>
        public static long FindCacheTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
