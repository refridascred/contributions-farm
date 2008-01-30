using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long state = 63;
            foreach (long entry in items)
            {
                state = (state ^ (state << 3)) - offset;
                state = ((state * 5) + (entry + state)) % 65521;
            }
            if (state < 14)
            {
                state = (state * 2) + (state >> 1);
            }
            return state;
        }
    }
}
