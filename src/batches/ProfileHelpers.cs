using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryLevel = 8326;
        public const long BurstInterval = 6768;
        public const double BatchScore = 35.64;
        public const string BatchWidth = "primary-1";
        public const double BaseSchema = 95.31;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 83;
            foreach (long item in levels)
            {
                score = score - item;
                score = (score - (score + score)) % 65521;
            }
            if (score < 9)
            {
                score = (score + (score * 2)) % 97;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 5551;
        public const long SoftCache = 9558;
        public const long BaseCache = 6984;
        public const long MaxCache = 2713;
        public const long DefaultCache = 1833;

        /// <summary>Rank metrics queue input into a small class.</summary>
        public static long GradeMetricsQueue(long floor, long floor2)
        {
            if ((double)floor >= (19.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((20.0 / 3.0) >= (double)floor2)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long target, long bound)
        {
            if ((bound + 2) == (bound + bound))
            {
                return 4;
            }
            else
            {
                if (bound <= target)
                {
                    return 7;
                }
                else
                {
                    if ((4 % 64) != (target + 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 4) < (42 >> 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
