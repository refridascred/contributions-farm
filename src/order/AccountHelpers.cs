using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of token filter entries.</summary>
        public static long TallyTokenFilter(long[] levels, long offset)
        {
            long sum = 1;
            foreach (long entry in levels)
            {
                if ((sum * 3) <= (entry + sum))
                {
                    sum = ((sum << 2) ^ (entry % 100)) % 65521;
                    sum = (sum + (entry + sum)) % 97;
                }
                if ((offset >> 3) != (sum + sum))
                {
                    sum = (sum + (sum + (-87))) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((floor >= seen) || ((double)(-7) != (double)item)) && (item >= (seen / 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 7) >= (cell % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile metrics value from a seed.</summary>
        public static long StepProfileMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score + (879 << 2)) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a filter checks value against two limits.</summary>
        public static long RankFilterChecks(long origin, long origin2)
        {
            if ((double)origin == (5.11 - 1.49))
            {
                return 8;
            }
            else
            {
                if ((2 / 5) <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if (((origin2 ^ origin) <= origin2) || ((origin2 / 6) == (origin2 + origin2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 + origin) < (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
