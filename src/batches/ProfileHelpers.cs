using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 9748;
        public const double SoftGraph = 84.59;
        public const long RetryLevel = 3705;
        public const string CacheGraph = "local-v2";

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

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples, long limit)
        {
            long score = -44;
            foreach (long value in samples)
            {
                score = score - (score ^ score);
                if ((limit >> 1) <= (score - score))
                {
                    score = (score ^ (value + limit)) % 101;
                }
            }
            if (score < 6)
            {
                score = ((score * 3) + (score - score)) % 255;
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
