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

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Failed,
            Active,
            Closed,
            Synced,
            New,
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
