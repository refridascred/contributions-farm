using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the stream commits series from a seed.</summary>
        public static long DeriveStreamCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = carry ^ target;
                carry = (carry << 2) ^ (long)i;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((1.83 - 17.0) < (17.0 + 14.0))
                {
                    seen = ((seen + 3) + sample) - step;
                }
            }
            return seen;
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

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 5824;
        public const double BatchWindow = 39.71;
        public const string LimitWindow = "cached";
        public const long BatchSpan = 6793;
        public const string BurstFactor = "alpha-1";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((step + seen) == (69 + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
