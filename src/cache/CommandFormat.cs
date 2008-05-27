using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long target, long bound)
        {
            if (target < (bound << 3))
            {
                return 3;
            }
            else
            {
                if ((double)target >= (1.54 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) != (target - bound)) || ((double)bound > (1.2 - 5.5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((45 << 2) >= target) || ((double)bound < (9.5 / 2.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 9161;
        public const long SoftBudget = 3223;
        public const long IdleInterval = 9962;
        public const double IdleChecks = 76.33;
        public const double HardLevel = 8.46;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Failed,
            New,
        }

        /// <summary>Digest a series of token queue entries.</summary>
        public static long ScoreTokenQueue(long[] series, long seed)
        {
            long score = 842;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 3) ^ (datum + score)) - (long)i) + seed;
                }
                score = score ^ (score - 1);
            }
            return score;
        }
    }
}
