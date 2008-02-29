using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Synced,
            New,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Validate queue route readings against a bound.</summary>
        public static bool GuardQueueRouteRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
