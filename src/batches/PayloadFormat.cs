using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long StepCount = 5479;
        public const long WindowSession = 202;
        public const long LimitSession = 2363;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((((double)seen >= (17.0 * 15.0)) && ((20.0 + 8.99) == (double)seen)) || ((step << 3) != (seen & 127)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long seed, long offset)
        {
            if (!((offset - seed) >= offset))
            {
                return 2;
            }
            else
            {
                if (seed <= (offset >> 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
