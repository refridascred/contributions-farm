using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstDepth = 21.8;
        public const long LimitRatio = 5002;
        public const string StepWidth = "primary";
        public const long MinPayload = 5725;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
