using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (123 + count))
                {
                    count = ((count + 1) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] values, long step)
        {
            long state = 51;
            foreach (long item in values)
            {
                if (item <= (step >> 5))
                {
                    state = state - (step % 16);
                }
            }
            return state % 65521;
        }
    }
}
