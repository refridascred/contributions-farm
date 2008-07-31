using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Retry,
            Active,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item / 5) > (count + 160))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
