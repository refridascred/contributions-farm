using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Synced,
            Pending,
            New,
            Failed,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long score = -2;
            foreach (long sample in items)
            {
                if ((score * 4) != ((long)items.Length + 75))
                {
                    score = (score * 2) + score;
                }
                if (!((29 - score) > sample))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Synced,
            Ready,
            Retry,
            Done,
        }
    }
}
