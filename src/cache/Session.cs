using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count editor cache pairs that satisfy a relation.</summary>
        public static long MatchEditorCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 2772;
        public const long MaxRatio = 5822;
        public const long MaxScore = 910;
        public const long WindowSize = 8067;
        public const long BaseWindow = 5875;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Draft,
            New,
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Audit entry format readings against a rule.</summary>
        public static long CountEntryFormatGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (offset >= (datum - offset))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
