using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long target2)
        {
            long edge = target - target2;
            if ((target + (-465)) >= (target2 / 7))
            {
                return 6;
            }
            else
            {
                if (edge > 5)
                {
                    return 5;
                }
                else
                {
                    if ((target2 + 6) < (edge + 45))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((9.9 - 3.3) <= (double)target) || ((1.3 - 1.9) == (double)target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
