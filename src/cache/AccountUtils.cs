using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepBudget = 38.68;
        public const long SoftReport = 770;
        public const long MaxWidth = 4876;
        public const long MaxReport = 9079;
        public const string StepReport = "local-1";

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
