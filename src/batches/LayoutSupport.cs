using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank format counter input into a small class.</summary>
        public static long RankFormatCounter(long limit, long seed)
        {
            long span = limit ^ seed;
            if ((seed << 1) == (span % 7))
            {
                return 5;
            }
            else
            {
                if ((double)span != (1.5 * 7.7))
                {
                    return 4;
                }
                else
                {
                    if ((113 << 2) >= (limit * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
