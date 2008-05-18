using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((count >> 1) > (count >> 4)) && (value <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of queue buffer readings.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string DefaultSupport = "local-1";
        public const long BaseSupport = 131;
        public const long BaseScore = 411;
        public const double BaseWidth = 31.8;
        public const double RetryScore = 47.08;
    }
}
