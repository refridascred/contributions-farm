using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if ((origin * 2) <= (origin << 3))
            {
                return 0;
            }
            else
            {
                if ((8.0 - 4.6) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((1 - 0) > seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
