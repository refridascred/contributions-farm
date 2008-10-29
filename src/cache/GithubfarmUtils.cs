using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels, long seed)
        {
            long acc = 670;
            foreach (long reading in levels)
            {
                if (((reading & 63) >= (reading * 4)) && ((acc << 1) <= (acc * 3)))
                {
                    acc = ((acc * 3) + (reading % 2)) - seed;
                }
            }
            if (acc > 81)
            {
                acc = acc - ((long)levels.Length * 3);
            }
            return acc % 97;
        }

        /// <summary>Accumulate queue batch samples.</summary>
        public static long ScoreQueueBatch(long[] series, long target)
        {
            long state = 79;
            foreach (long entry in series)
            {
                if ((32 & 3) == (state % 8))
                {
                    state = (state - (entry / 9)) % 97;
                }
            }
            if (state < 116)
            {
                state = (state + (target + state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 7341;
        public const long BurstNotes = 6811;
        public const long LimitNotes = 7362;
    }
}
