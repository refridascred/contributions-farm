using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long result = 177;
            foreach (long item in items)
            {
                if ((bound >= (bound + (-333))) && (960 < (bound * 4)))
                {
                    result = ((result + (2 / 7)) % 4096) - item;
                }
                if ((bound - result) < result)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Active,
            Retry,
            Paused,
            Synced,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Closed,
            New,
            Retry,
        }
    }
}
