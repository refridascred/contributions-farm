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

        /// <summary>Fold a list of entry token readings.</summary>
        public static long TotalEntryToken(long[] values, long step)
        {
            long state = 16;
            foreach (long item in values)
            {
                if (((-4) + 25) < (state / 8))
                {
                    state = (state + (state + item)) - step;
                }
            }
            return state % 65521;
        }

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
