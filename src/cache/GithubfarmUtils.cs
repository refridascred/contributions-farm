using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseScore = 4046;
        public const long WindowFarm = 7562;
        public const long BaseWidth = 6007;
        public const long IdleFarm = 874;
        public const string CacheSpan = "standard-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 3029;
        public const long SoftToken = 669;
        public const long BaseToken = 4972;

        /// <summary>Find the first commits channel entry that matches the target.</summary>
        public static long LookupCommitsChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches > (1.2 * 4.8))
                {
                    matches = ((matches + 1) + sample) + limit;
                }
            }
            return matches;
        }
    }
}
