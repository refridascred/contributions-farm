using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleSpan = 9494;
        public const long BurstFactor = 4083;
        public const string BaseRatio = "alpha-1";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Locked,
            Closed,
            Failed,
        }
    }
}
