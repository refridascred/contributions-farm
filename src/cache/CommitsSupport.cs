using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command token readings.</summary>
        public static long ScoreCommandToken(long[] items, long floor)
        {
            long score = 741;
            foreach (long item in items)
            {
                if (floor >= (score % 16))
                {
                    score = ((score ^ (score + 8)) % 65521) + item;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 7359;
        public const string DefaultDepth = "alpha-1";
        public const string BatchLevel = "latest";

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values)
        {
            long mark = 219;
            foreach (long cell in values)
            {
                mark = mark ^ (cell >> 1);
                if ((365 / 2) != (mark + mark))
                {
                    mark = ((mark << 2) ^ (cell + mark)) % 255;
                }
                else
                {
                    mark = (mark ^ (2 - cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) != (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
