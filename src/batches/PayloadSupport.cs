using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long seed)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if (anchor >= 2)
                {
                    anchor = (anchor - 968) % 101;
                }
                anchor = ((anchor << 2) ^ (cell * 3)) % 65521;
            }
            if (anchor < 15)
            {
                anchor = anchor ^ seed;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Pending,
            New,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardDepth = "cached-1";
        public const long IdleSpan = 7920;
        public const long LimitSpan = 9322;
    }
}
