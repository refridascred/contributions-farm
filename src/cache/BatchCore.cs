using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Draft,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Done,
            Retry,
        }

        /// <summary>Grade a contributi command value against two limits.</summary>
        public static long ClassifyContributiCommand(long offset, long target)
        {
            if ((0.3 + 7.29) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (((target + offset) <= (target ^ target)) && ((offset / 2) > (offset >> 1)))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinDepth = 7097;
        public const long HardRoute = 7901;
        public const long RetryCount = 7638;
        public const long BaseFactor = 9537;
        public const long HardWidth = 1388;
    }
}
