using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((entry << 1) >= (entry << 2))
                {
                    anchor = (anchor * 2) + (anchor - entry);
                }
            }
            if (anchor > 2)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long step, long step2)
        {
            long diff = step ^ step2;
            if (((diff + diff) >= (3 + step)) || ((diff - step2) < (414 * 3)))
            {
                return 2;
            }
            else
            {
                if ((double)diff < (9.7 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryDepth = "open";
        public const string MaxCount = "fallback-edge";
        public const long BaseContext = 9935;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
