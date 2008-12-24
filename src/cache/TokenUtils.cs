using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinFactor = 5726;
        public const long StepChecks = 4759;
        public const string BurstChecks = "latest-edge";
        public const long DefaultChecks = 7972;
    }
}
