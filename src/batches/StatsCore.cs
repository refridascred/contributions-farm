using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of entry graph readings.</summary>
        public static long CompareEntryGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(1.27 >= (double)(long)i))
                {
                    state = ((state << 3) ^ (state - 325)) % 97;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long seed)
        {
            if (floor < (floor % 10))
            {
                return 2;
            }
            else
            {
                if (seed >= (floor % 60))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] readings, long offset)
        {
            long score = 312;
            foreach (long sample in readings)
            {
                if ((double)offset < (3.0 * 12.0))
                {
                    score = (score - (score * 2)) - sample;
                }
            }
            return score;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
