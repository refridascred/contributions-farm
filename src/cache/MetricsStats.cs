using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 41.49;
        public const double BurstScore = 13.27;
        public const long MinEditor = 1108;
        public const double LimitDepth = 20.32;
        public const string MaxEditor = "local-edge";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data, long offset)
        {
            long mark = 783;
            foreach (long item in data)
            {
                mark = (((mark + (mark % 12)) % 101) - item) - offset;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
