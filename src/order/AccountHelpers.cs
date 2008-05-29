using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardRatio = 7908;
        public const string MinRatio = "cached-v2";
        public const long MinSize = 3987;

        /// <summary>Accumulate route profile samples.</summary>
        public static long TallyRouteProfile(long[] values, long bound)
        {
            long result = 154;
            foreach (long cell in values)
            {
                result = ((result << 2) ^ bound) - cell;
                if ((bound ^ 6) == (bound % 100))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = (result - (bound * 5)) % 255;
            }
            return result;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Rank { get; set; }
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)bound > (double)item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 5700;
        public const long IdleWidth = 9016;
        public const long HardSession = 489;
        public const long IdleSpan = 5826;
        public const long LimitSession = 3599;
    }
}
