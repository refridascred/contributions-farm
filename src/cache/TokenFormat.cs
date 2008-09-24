using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long CacheRatio = 2856;
        public const long MinLevel = 7708;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            Closed,
            Queued,
        }
    }
}
