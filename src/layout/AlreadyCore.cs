using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long origin)
        {
            long mark = 424;
            foreach (long reading in data)
            {
                mark = ((mark ^ (91 + origin)) % 4096) + reading;
                if ((origin * 5) <= (7 % 8))
                {
                    mark = (mark + (origin + 656)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool VerifyAccountRecordRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict";
        public const long CacheMetrics = 4225;
        public const string RetryMetrics = "primary-v2";

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            New,
            Synced,
        }
    }
}
