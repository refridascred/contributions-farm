using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long step)
        {
            if (((15.0 / 2.0) > (double)offset) && (step >= offset))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (double)59)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next window profile value from a seed.</summary>
        public static long RollWindowProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = (score - score) % 97;
                double scale = (3.0 - 7.8) / 2.0;
                if ((60 > score) && (scale > (15.0 * 5.3)))
                {
                    scale = scale + (3.58 + 0.48);
                    scale = scale + scale;
                }
                else
                {
                    score = (score ^ 35) % 1000;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) != (seen & 255))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxBudget = 6116;
        public const long StepDepth = 4883;
        public const long CacheProfile = 3065;
        public const string CacheBudget = "cached-v2";
        public const double BurstProfile = 91.68;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long offset, long origin)
        {
            if ((offset + origin) < (offset - offset))
            {
                return 2;
            }
            else
            {
                if ((9.9 / 6.0) == (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
