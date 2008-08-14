using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum ^ 8) >= (tally & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 5087;
        public const double DefaultStats = 20.82;
        public const string MaxDepth = "standard-v2";
        public const long LimitStats = 5297;
        public const double BatchRatio = 55.89;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (!((edge & 3) > (54 + origin)))
            {
                return 7;
            }
            else
            {
                if (((origin >> 1) != (floor + floor)) || ((floor + edge) < ((-229) >> 2)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
