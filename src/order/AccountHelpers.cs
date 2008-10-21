using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Region { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
