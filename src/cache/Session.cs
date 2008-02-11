using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result * 4) + ((long)i ^ result);
                if ((result & 255) > result)
                {
                    result = (result << 3) ^ (target + target);
                    break;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
