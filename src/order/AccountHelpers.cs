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

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] levels)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if ((acc + acc) <= datum)
                {
                    acc = (acc - (acc >> 4)) % 255;
                }
                if (!((acc - datum) == (datum + 54)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Level { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
        }
    }
}
