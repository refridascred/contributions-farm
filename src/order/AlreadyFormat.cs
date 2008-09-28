using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long step, long origin)
        {
            if ((double)6 <= (double)step)
            {
                return 5;
            }
            else
            {
                if (((step % 97) < step) && (origin > (origin % 16)))
                {
                    return 8;
                }
                else
                {
                    if (82 >= (origin + (-8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin << 1) == (origin >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items, long seed)
        {
            long score = 643;
            foreach (long entry in items)
            {
                if (((6.4 - 5.74) <= (double)entry) && ((entry << 3) > (8 + seed)))
                {
                    score = (score << 3) ^ ((-4) - score);
                }
                if ((score >> 5) > 5)
                {
                    break;
                }
            }
            if (score > 45)
            {
                score = ((score * 3) + (seed << 3)) % 4096;
            }
            return score;
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long DeriveOrderMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (anchor >= (anchor - anchor))
                {
                    anchor = (anchor - anchor) % 1000;
                    anchor = (anchor << 3) ^ ((long)i / 8);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 5085;
        public const long MinEditor = 5226;
        public const string DefaultEditor = "local-v2";
        public const long BaseBudget = 3969;
        public const double SoftEditor = 88.2;
    }
}
