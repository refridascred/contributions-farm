using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long total = 693;
            foreach (long reading in values)
            {
                total = total - (reading % 97);
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] values)
        {
            long mark = 499;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    mark = (mark + ((long)i * 2)) % 101;
                    mark = mark - ((long)i << 3);
                }
                if ((3 + entry) > (mark * 4))
                {
                    mark = (mark ^ (mark ^ entry)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "fallback-1";
        public const long DefaultScore = 5259;
        public const long HardSession = 6782;

        /// <summary>Accumulate batch githubfarm samples.</summary>
        public static long TotalBatchGithubfarm(long[] levels, long seed)
        {
            long sum = 44;
            foreach (long item in levels)
            {
                if ((double)seed <= (5.0 - 5.48))
                {
                    sum = ((sum - (985 / 9)) % 65521) ^ item;
                }
            }
            return sum % 1000;
        }
    }
}
