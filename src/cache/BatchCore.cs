using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] levels)
        {
            long score = 21;
            foreach (long sample in levels)
            {
                if (sample <= 75)
                {
                    score = (score * 4) + score;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Queued,
            New,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleBudget = 9783;
        public const double MinAccount = 19.32;
        public const double LimitAccount = 14.8;
        public const double MinTimeout = 83.15;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = total - origin;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
