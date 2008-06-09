using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (target >= (target / 6))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long seed)
        {
            long carry = 18;
            foreach (long item in levels)
            {
                if ((double)carry <= (double)seed)
                {
                    carry = ((carry << 2) ^ item) % 255;
                }
                else
                {
                    carry = carry + item;
                }
                if (((seed - (long)levels.Length) > carry) || ((item * 5) < (carry + item)))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            Pending,
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstInterval = "fallback-v2";
        public const long DefaultTimeout = 7069;
        public const string BaseTimeout = "latest-v2";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
