using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BaseCommits = 94.97;
        public const long WindowTimeout = 5610;
        public const double MaxCommits = 87.47;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Synced,
            Paused,
            Idle,
        }
    }
}
