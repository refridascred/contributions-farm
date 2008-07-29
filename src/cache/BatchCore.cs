using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBudget = "fallback";
        public const double LimitBatches = 65.86;
        public const string LimitScore = "strict-edge";

        /// <summary>Rank payload layout input into a small class.</summary>
        public static long GradePayloadLayout(long target, long bound)
        {
            if ((34 > (target + bound)) && (((-5) % 8) < (3 - target)))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (4.78 / 5.0))
                {
                    return 6;
                }
                else
                {
                    if ((bound / 5) < (target + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter schema value from a seed.</summary>
        public static long RollFilterSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - origin) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
