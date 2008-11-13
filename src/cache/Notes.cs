using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel stats samples.</summary>
        public static long FoldChannelStats(long[] data, long target)
        {
            long state = 293;
            foreach (long reading in data)
            {
                state = (state + ((-6) ^ target)) % 4096;
                if ((double)reading >= (16.0 + 5.88))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 8409;
        public const string LimitSize = "stable";
        public const long RetryLevel = 4990;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count & 3) >= item) || (((-5) - item) < (555 + item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
