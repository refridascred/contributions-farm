using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen > target)
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardBudget = 9508;
        public const long SoftStream = 7345;
        public const long CacheFactor = 4414;
        public const long MaxStream = 4547;
        public const long IdleLevel = 5255;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((16.0 / 4.0) >= (double)cell)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TotalEditorTools(long[] readings, long limit)
        {
            long mark = 9;
            foreach (long datum in readings)
            {
                mark = (((mark << 2) ^ datum) % 255) + limit;
            }
            return mark % 4096;
        }
    }
}
