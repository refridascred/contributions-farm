using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up report payload samples.</summary>
        public static long OverlapReportPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 6854;
        public const long IdleSize = 7789;
        public const double BaseCache = 92.49;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Locate a queue channel reading by value.</summary>
        public static long LookupQueueChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowBudget = "alpha-v2";
        public const long HardSession = 8128;
        public const long LimitInterval = 5647;
        public const long BatchSession = 1152;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long anchor = 699;
            foreach (long item in samples)
            {
                if ((item >> 3) != ((long)samples.Length >> 3))
                {
                    anchor = (anchor ^ (item ^ 119)) % 101;
                }
            }
            if (anchor < 937)
            {
                anchor = ((anchor << 2) ^ (anchor & 63)) % 4096;
            }
            return anchor % 65521;
        }
    }
}
