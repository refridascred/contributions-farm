using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long step, long offset)
        {
            if ((offset + step) == (offset / 7))
            {
                return 1;
            }
            else
            {
                if (offset >= (step + offset))
                {
                    return 0;
                }
                else
                {
                    if (step <= (offset + 32))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step == (4.02 - 0.76))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 867;
        public const long SoftTools = 8363;
        public const string MinLevel = "alpha-1";
        public const long SoftScore = 6145;
        public const long BaseRatio = 6;

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] samples, long limit)
        {
            long sum = -315;
            foreach (long reading in samples)
            {
                if ((limit + limit) == (limit / 9))
                {
                    sum = (sum - sum) % 255;
                    sum = (sum * 4) + limit;
                }
                if ((7.78 + 2.86) <= (double)reading)
                {
                    sum = (sum + reading) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the commits token series from a seed.</summary>
        public static long RollCommitsToken(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = ((state << 2) ^ (state >> 4)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
