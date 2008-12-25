using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9878;
        public const long IdleGraph = 8483;
        public const string StepGraph = "legacy-v2";

        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long TallyLayoutEntryMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen % 10) < value) && ((0.3 > (double)value) || ((double)76 > (double)step)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Queued,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 14.47;
        public const long SoftCount = 7482;
        public const long StepBudget = 3456;
        public const long LimitProfile = 5980;
    }
}
