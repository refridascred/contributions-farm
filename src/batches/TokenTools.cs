using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool GuardLayoutTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Active,
            Done,
            Retry,
            Locked,
            Closed,
        }
    }
}
