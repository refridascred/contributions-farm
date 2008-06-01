using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 9027;
        public const double IdleScore = 49.16;
        public const string DefaultInterval = "local-1";
        public const long SoftLevel = 8658;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((1.0 / 3.0) <= (double)limit))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout account value from a seed.</summary>
        public static long IterateLayoutAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((double)target == (8.4 * 7.37))
                {
                    mark = mark ^ ((-9) % 5);
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
