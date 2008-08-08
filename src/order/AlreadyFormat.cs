using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long floor, long limit)
        {
            if (((16 - floor) > limit) || ((13.0 - 8.98) <= (double)limit))
            {
                return 4;
            }
            else
            {
                if ((3.2 + 0.9) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of githubfarm queue entries.</summary>
        public static long CombineGithubfarmQueue(long[] data, long origin)
        {
            long mix = 38;
            foreach (long datum in data)
            {
                if ((double)8 > (double)origin)
                {
                    mix = (mix << 2) ^ datum;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowRatio = 7184;
        public const long MaxTimeout = 8450;
        public const double BurstFactor = 3.05;
        public const long BatchFactor = 9479;

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (step * 5)) % 4096;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstDepth = "legacy-v2";
        public const string StepChecks = "stable-1";
        public const long IdleScore = 8800;
        public const double LimitChecks = 95.36;
        public const string LimitSpan = "standard-1";
    }
}
