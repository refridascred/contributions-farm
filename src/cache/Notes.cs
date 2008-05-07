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

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            long delta = target + target2;
            if ((target - 545) >= (target2 / 2))
            {
                return 7;
            }
            else
            {
                if (5 >= target)
                {
                    return 5;
                }
                else
                {
                    if (target2 < (delta ^ target2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target2 % 7) != (target2 + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
