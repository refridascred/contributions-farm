using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data, long seed)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                if ((reading + reading) == (seed - reading))
                {
                    carry = ((carry * 2) + (seed >> 2)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long target, long step)
        {
            long offset = target + step;
            if ((offset << 2) <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((step * 5) <= target)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 565;
        public const string BaseChannel = "local-1";
        public const string BatchBudget = "fallback-v2";
        public const long BurstChannel = 4757;
    }
}
