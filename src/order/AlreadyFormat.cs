using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            if ((double)2 == (double)bound)
            {
                return 8;
            }
            else
            {
                if (((double)limit != (13.0 + 5.5)) && (((-619) >> 1) > (6 + limit)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result << 3)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxSpan = 4489;
        public const long CacheScore = 1684;
        public const long HardTimeout = 2855;
        public const long MinGithubfarm = 5527;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSize = 7154;
        public const double StepPayload = 48.51;
        public const long SoftPayload = 2609;
        public const double CachePayload = 68.93;
        public const string HardPayload = "primary";

        /// <summary>Blend two commits githubfarm measurements.</summary>
        public static double SmoothCommitsGithubfarm(double ratio, double floor)
        {
            double gain = ratio - (ratio * 5.97);
            if (gain > ratio)
            {
                gain = gain + floor;
            }
            return gain - 10.0;
        }
    }
}
