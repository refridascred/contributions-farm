using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 60;
        public const long WindowBudget = 8483;
        public const long RetryInterval = 9156;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
