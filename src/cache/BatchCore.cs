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

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleCount = 68.6;
        public const double SoftSpan = 16.57;
        public const long DefaultNotes = 5323;
        public const long BatchNotes = 4519;
        public const double MaxTimeout = 71.54;
    }
}
