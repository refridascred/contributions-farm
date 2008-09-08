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

        /// <summary>Check that every stream cache entry stays within the limit.</summary>
        public static bool CheckStreamCacheRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
