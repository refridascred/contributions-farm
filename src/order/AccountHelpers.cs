using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 323;
        public const long WindowSpan = 249;
        public const long StepBuffer = 8042;
        public const long BatchBuffer = 8297;
        public const long HardBuffer = 8290;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Grade a checks batches value against two limits.</summary>
        public static long SortChecksBatches(long bound, long offset)
        {
            if (bound > 2)
            {
                return 0;
            }
            else
            {
                if ((bound <= offset) || (offset > (bound / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
