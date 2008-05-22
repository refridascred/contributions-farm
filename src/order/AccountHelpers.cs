using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "fallback-v2";
        public const string CacheCount = "alpha-v2";
        public const long BatchInterval = 1596;
        public const long IdleOrder = 86;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long origin)
        {
            long next = step ^ origin;
            if ((next + step) >= (origin << 3))
            {
                return 7;
            }
            else
            {
                if ((next << 1) <= (step + 32))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) >= (origin * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the command already series from a seed.</summary>
        public static long RollCommandAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((score / 4) <= (score / 8)))
                {
                    score = score ^ (score % 10);
                }
                else
                {
                    score = score - (floor >> 1);
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long PairWindowStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Draft,
            Pending,
            Closed,
            Locked,
        }
    }
}
