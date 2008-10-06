using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the token metric entries that pass the check.</summary>
        public static long AuditTokenMetricGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!!((cell % 5) != (seen + cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Idle,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchBudget = "fallback";
        public const long BaseStream = 8576;
        public const string SoftStream = "staging";
        public const long WindowStream = 9869;
        public const long StepScore = 3714;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
