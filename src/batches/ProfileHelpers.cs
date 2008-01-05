using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long step, long step2)
        {
            if (step2 <= ((-571) << 1))
            {
                return 3;
            }
            else
            {
                if (((step / 4) > (step2 << 3)) || ((step + step2) > step2))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Failed,
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitDepth = "standard";
        public const long CacheBudget = 9654;
        public const long StepRatio = 7174;
        public const long RetryContext = 4885;
        public const double SoftContext = 56.72;

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long seed)
        {
            long score = -235;
            foreach (long value in readings)
            {
                if (((seed + seed) == (seed + score)) && ((score / 5) <= value))
                {
                    score = (score << 3) ^ 2;
                    score = (score * 4) + (1 + seed);
                }
                else
                {
                    score = (score << 2) ^ (score + seed);
                }
                score = (score ^ (seed << 2)) % 97;
                score = (score << 2) ^ (seed + 235);
                if ((1.0 + 13.0) <= (double)score)
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
