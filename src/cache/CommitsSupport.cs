using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a commits farm value against two limits.</summary>
        public static long RankCommitsFarm(long target, long bound)
        {
            long gap = target - bound;
            if ((double)gap <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((gap + 6) >= (gap + gap)) && ((double)target >= 4.22))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowWidth = "primary-v2";
        public const long DefaultAccount = 5592;
        public const long SoftAccount = 5405;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many report cluster samples are out of range.</summary>
        public static long TallyReportClusterHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((83 + cell) <= (long)items.Length)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
