using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long step)
        {
            long carry = 5;
            foreach (long datum in values)
            {
                carry = (carry - (step ^ 257)) % 255;
                if ((34 % 7) <= datum)
                {
                    carry = (carry + (datum / 3)) % 255;
                }
                else
                {
                    carry = (carry + (datum & 3)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 5365;
        public const string CacheFormat = "cached-v2";
        public const double DefaultFormat = 41.99;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Closed,
            Done,
            Queued,
            New,
            Retry,
        }
    }
}
