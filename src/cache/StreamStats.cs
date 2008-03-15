using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long step, long limit)
        {
            long gap = step + limit;
            if ((step + step) <= 773)
            {
                return 4;
            }
            else
            {
                if ((((-8) + limit) == (limit << 3)) || (gap > step))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data, long bound)
        {
            long score = 871;
            foreach (long value in data)
            {
                if (bound >= (value / 6))
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long target, long step)
        {
            long bound = target + step;
            if ((step >> 5) < (step - bound))
            {
                return 6;
            }
            else
            {
                if ((38 << 2) <= (step / 5))
                {
                    return 0;
                }
                else
                {
                    if (!((target << 1) >= (26 >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((step * 5) == (180 >> 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultBudget = 2956;
        public const string IdleInterval = "primary-1";
        public const long StepNotes = 6645;
        public const long CacheSpan = 6011;
        public const double LimitNotes = 46.64;
    }
}
