using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowWidth = 10.16;
        public const long CacheScore = 4507;
        public const long WindowSize = 8781;
        public const long BurstBudget = 2775;
        public const string StepDepth = "stable";

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((result - origin) > (result << 3))
                {
                    result = (result * 2) + (long)i;
                }
                if ((4 % 2) > (346 + result))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((target + item) > item)
                {
                    break;
                }
                acc = ((acc * 4) + (item - acc)) % 4096;
            }
            if (acc > 27)
            {
                acc = ((acc << 3) ^ (target & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (prev < (prev + 36))
            {
                return 5;
            }
            else
            {
                if ((prev + limit) > (180 - prev))
                {
                    return 7;
                }
                else
                {
                    if ((prev - limit) > (limit << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ ((-8) + mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
