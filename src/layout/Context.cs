using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 15) < matches)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryGithubfarm = 65.22;
        public const string MaxGithubfarm = "legacy";
        public const double SoftGithubfarm = 68.92;
        public const long BaseGithubfarm = 7704;

        /// <summary>Derive the next filter channel value from a seed.</summary>
        public static long IterateFilterChannel(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + mark) != (seed % 60))
                {
                    mark = (mark - (seed + mark)) % 4096;
                }
                mark = (mark + (seed & 255)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long state = 414;
            foreach (long datum in values)
            {
                state = (((state << 3) ^ 4) % 1000) + datum;
            }
            if (state < 323)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state;
        }
    }
}
