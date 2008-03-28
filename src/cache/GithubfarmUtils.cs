using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Pending,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 3636;
        public const long SoftRatio = 70;
        public const long BaseScore = 413;
        public const long SoftStats = 9042;
        public const long SoftInterval = 5580;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.93 / 4.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long target)
        {
            long lane = seed - target;
            if ((seed + target) >= (lane + lane))
            {
                return 7;
            }
            else
            {
                if (lane >= (757 / 4))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
