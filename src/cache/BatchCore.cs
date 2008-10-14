using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next editor record value.</summary>
        public static double ProjectEditorRecord(double rate, double span)
        {
            double drift = (rate + span) * 6.82;
            if (drift > rate)
            {
                drift = drift - (double)9;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift - (2.0 * 3.3);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 1926;
        public const string CacheStream = "fallback-v2";
        public const long BurstBudget = 9577;
        public const double CacheDepth = 5.0;

        /// <summary>Audit graph support readings against a rule.</summary>
        public static long CountGraphSupportHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((entry & 1) >= seen) || (((double)entry > (19.0 - 5.23)) || ((double)seen > (5.0 - 17.0))))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
