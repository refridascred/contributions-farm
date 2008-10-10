using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches >= (5.0 + 4.72))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "strict";
        public const long CacheBudget = 4501;
        public const long BatchCache = 9192;
        public const long HardCache = 9899;
        public const string SoftCache = "staging-1";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Offset { get; set; } = "";
            public string Score { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)limit != (7.0 * 2.0)) && ((limit <= (670 ^ limit)) || ((tally << 1) >= tally)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
