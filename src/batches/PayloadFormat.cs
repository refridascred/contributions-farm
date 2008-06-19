using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry queue entries that pass the check.</summary>
        public static long AuditEntryQueueOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((limit - value) == (seen % 100))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "open";
        public const long HardStats = 6030;
        public const long BaseCount = 1765;
        public const long LimitStats = 8348;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits >> 3) >= sample) && !(679 > (hits << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long anchor = 44;
            foreach (long sample in values)
            {
                anchor = anchor ^ (sample << 1);
                anchor = (anchor - anchor) % 4096;
                if ((4.02 + 2.0) != (double)anchor)
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                }
                else
                {
                    anchor = (anchor + (anchor & 15)) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
