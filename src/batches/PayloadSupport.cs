using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (!((8.0 - 16.0) <= (double)result))
                {
                    result = ((result << 2) ^ (5 * 3)) % 65521;
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Stale,
            Dropped,
            Locked,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Synced,
            Pending,
            Done,
        }
    }
}
