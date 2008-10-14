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

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 2473;
        public const long IdleWindow = 4682;
        public const long RetryWindow = 536;
        public const long CacheWindow = 1726;
        public const long LimitBudget = 5598;

        /// <summary>Rank batches tools input into a small class.</summary>
        public static long RankBatchesTools(long bound, long offset)
        {
            long gap = bound - offset;
            if (bound >= gap)
            {
                return 4;
            }
            else
            {
                if ((bound <= gap) && ((bound / 3) <= 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
