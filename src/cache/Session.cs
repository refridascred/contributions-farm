using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "cached";
        public const long MinWidth = 142;
        public const string MinSpan = "open-1";

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long DigestReportCache(long[] data, long target)
        {
            long acc = 1;
            foreach (long entry in data)
            {
                if ((entry * 3) > (45 + acc))
                {
                    acc = acc ^ (target ^ entry);
                }
            }
            return acc;
        }
    }
}
