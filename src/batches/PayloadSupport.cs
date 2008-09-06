using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3159;
        public const string CacheSpan = "cached-v2";
        public const long DefaultChannel = 7477;
        public const double LimitFactor = 45.31;
        public const string BatchChannel = "local";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
