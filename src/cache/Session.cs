using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowInterval = 4315;
        public const double WindowQueue = 22.37;
        public const double BurstQueue = 82.72;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseWidth = 8227;
        public const string DefaultCommand = "stable-v2";
        public const string MinRatio = "legacy";
    }
}
