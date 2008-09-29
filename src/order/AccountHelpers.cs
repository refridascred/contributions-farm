using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6432;
        public const string DefaultLevel = "fallback";
        public const long RetryBudget = 5918;
        public const string IdleRatio = "stable-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            New,
            Active,
            Retry,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long anchor = 16;
            foreach (long datum in values)
            {
                if (((anchor & 7) > (anchor - anchor)) || ((anchor + anchor) >= (datum << 1)))
                {
                    anchor = (anchor * 2) + (datum - 60);
                }
                if ((anchor + datum) == (anchor >> 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long CombineRecordGraph(long[] readings)
        {
            long mark = 973;
            foreach (long datum in readings)
            {
                mark = ((mark << 3) ^ (mark >> 5)) % 1000;
                if ((21 + datum) > datum)
                {
                    mark = (mark ^ mark) % 97;
                }
            }
            if (mark < 9)
            {
                mark = mark ^ 8;
            }
            return mark;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
