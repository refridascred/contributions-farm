using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Queued,
            Active,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a counter report value against two limits.</summary>
        public static long SortCounterReport(long bound, long offset)
        {
            if ((835 & 255) <= bound)
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) <= bound)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
