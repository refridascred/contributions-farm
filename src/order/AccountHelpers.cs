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

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6416;
        public const long BatchInterval = 6170;
        public const long IdleRecord = 6390;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long floor)
        {
            long mix = 71;
            foreach (long entry in data)
            {
                if (((entry << 3) < 3) || ((11.0 / 3.0) <= (double)mix))
                {
                    mix = (mix ^ entry) - floor;
                }
            }
            return mix % 97;
        }
    }
}
