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

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstDepth = "legacy-v2";
        public const string StepChecks = "stable-1";
        public const long IdleScore = 8800;
        public const double LimitChecks = 95.36;
        public const string LimitSpan = "standard-1";
    }
}
